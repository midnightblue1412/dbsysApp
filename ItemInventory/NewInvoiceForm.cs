using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemInventory
{
    public partial class NewInvoiceForm : ChildForm
    {
        decimal _currentTotal;

        decimal currentTotal
        {
            set
            {
                _currentTotal = value;
                disp_total.Text = value == 0 ? "":value.ToString("C");
            }

            get
            {
                return _currentTotal;
            }
        }

        public NewInvoiceForm()
        {
            InitializeComponent();
        }

        /*
         *  METHODS
         */
        private void initTables()
        {
            dbm.dbmgr.InvoiceTableAdapter.Fill(dbm.db.Invoice);
            dbm.dbmgr.InvoiceItemTableAdapter.Fill(dbm.db.InvoiceItem);
            dbm.dbmgr.ItemTableAdapter.Fill(dbm.db.Item);
            dbm.dbmgr.ClientTableAdapter.Fill(dbm.db.Client);
        }

        private void fillItemComboBox()
        {
            RecordsDataSet.ItemRow[] items =
                (from item in dbm.db.Item
                where item.itemStatus.Equals("AV")
                select item).ToArray();

            input_itemName.Items.AddRange(items);
        }

        private void fillClientComboBox()
        {
            RecordsDataSet.ClientRow[] clients =
                (from client in dbm.db.Client
                 where client.clientStatus.Equals("AC")
                 select client).ToArray();

            input_clientName.Items.AddRange(clients);
        }

        private int findRow(int itemId)
        {
            int i = 0;
            foreach (DataGridViewRow r in disp_grid.Rows)
            {
                DataGridViewCellCollection c = r.Cells;

                if (c["itemId"].Value.Equals(itemId))
                {
                    return i;
                }
                i++;
            }

            return -1;
        }

        private RecordsDataSet.InvoiceRow makeInvoice()
        {
            return dbm.db.Invoice.AddInvoiceRow(
                input_invoiceNo.Text,
                input_date.Value,
                input_clientName.SelectedItem as RecordsDataSet.ClientRow);
        }

        private int addInvoiceItems(RecordsDataSet.InvoiceRow invoice)
        {
            foreach (DataGridViewRow r in disp_grid.Rows)
            {
                DataGridViewCellCollection c = r.Cells;

                dbm.db.InvoiceItem.AddInvoiceItemRow(
                    invoice,
                    c["itemName"].Value as RecordsDataSet.ItemRow,
                    (int)c["quantity"].Value,
                    "PENDING");
            }

            return disp_grid.Rows.Count;
        }

        /*
         *  EVENT HANDLERS
         */
        private void NewInvoiceForm_Load(object sender, EventArgs e)
        {
            initTables();
            fillItemComboBox();
            fillClientComboBox();
        }

        private void input_itemName_TextChanged(object sender, EventArgs e)
        {
            int index = input_itemName.FindStringExact(input_itemName.Text);
            input_itemName.SelectedIndex = index;

            if (index >= 0)
            {
                input_qty.Value = 1;
            }
            else
            {
                input_qty.Value = 0;
            }
        }

        private void input_clientName_TextChanged(object sender, EventArgs e)
        {
            string clientNameTxt = input_clientName.Text.Trim();
            int index = input_clientName.FindStringExact(clientNameTxt);
            input_clientName.SelectedIndex = index;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            RecordsDataSet.ItemRow item = input_itemName.SelectedItem as RecordsDataSet.ItemRow;
            int index = findRow(item.id);
            int qty = (int)input_qty.Value;

            if (input_itemName.SelectedItem == null)
            {
                MainForm.showErrorMessage("Select an item first!");
            }
            else if (qty < 1)
            {
                MainForm.showErrorMessage("Invalid Quantity");
            }
            else if(index >= 0)
            {
                decimal orig_subTotal = item.unitPrice * (int)disp_grid.Rows[index].Cells["quantity"].Value;
                decimal subTotal = item.unitPrice * qty;

                disp_grid.Rows[index].Cells["quantity"].Value = qty;
                disp_grid.Rows[index].Cells["subtotal"].Value = subTotal.ToString("C");

                currentTotal += subTotal - orig_subTotal;
            }
            else
            {
                decimal subTotal = item.unitPrice * qty;

                currentTotal += subTotal;

                disp_grid.Rows.Add(item.id,
                    item,
                    item.unitPrice.ToString("C"),
                    qty,
                    subTotal.ToString("C"));

                disp_total.Text = currentTotal.ToString("C");
            }
        }

        private void disp_grid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {            
            currentTotal -= decimal.Parse(e.Row.Cells["subtotal"].Value.ToString().Substring(1));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string invoiceNoTxt = input_invoiceNo.Text;
            if (string.IsNullOrEmpty(invoiceNoTxt))
            {
                input_invoiceNo.Focus();
                MainForm.showErrorMessage("Please enter the invoice number.");
            }
            else if (input_clientName.SelectedItem == null)
            {
                input_clientName.Focus();
                MainForm.showErrorMessage("Please select client.");
            }
            else if(currentTotal == 0)
            {
                MainForm.showErrorMessage("Invoice Cannot be Empty!");
            }
            else
            try
            {
                RecordsDataSet.InvoiceRow invoice = makeInvoice();
                int rowsAdded = addInvoiceItems(invoice);                

                dbm.dbmgr.UpdateAll(dbm.db);
                MainForm.showSuccessMessage(
                    "Successfuly created invoice record with " + rowsAdded + " item(s).");
            }
            catch (DBConcurrencyException ex)
            {
                DialogResult res =
                        MainForm.showErrorPrompt(
                            "Failed to sync with database.\n\n" + 
                            "Details:\n" + ex.Message);

                if (res.Equals(DialogResult.Retry))
                {
                    btn_save_Click(sender, e);
                }
                else
                {
                    dbm.db.RejectChanges();
                }
            }
            catch(Exception ex)
            when (ex is ConstraintException || ex is Exception)
            {
                dbm.db.RejectChanges();
                if (ex is ConstraintException)
                {
                    MainForm.showErrorMessage(
                        "A Constraint was violated while trying to " + 
                        "perform action:\n\n" + 
                        ex.Message);
                }
                else
                {
                    MainForm.showErrorMessage(
                        "An Unexpected Error Occured.\n\n" +
                        "Details:\n" + ex.Message);
                }
            }            
        }
    }
}
