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
    public partial class InvoiceForm : ChildForm
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        /*
         *  METHODS
         */
         private void initTables ()
        {
            dbm.dbmgr.ClientTableAdapter.Fill(dbm.db.Client);
            dbm.dbmgr.InvoiceTableAdapter.Fill(dbm.db.Invoice);
            dbm.dbmgr.InvoiceItemTableAdapter.Fill(dbm.db.InvoiceItem);
        }

        private void fillInvoiceNoComboBox()
        {
            input_invoiceNo.Items.Clear();
            input_invoiceNo.Items.AddRange(
                (from invoice in dbm.db.Invoice select invoice).ToArray());
        }

        private void showInvoiceInfo(RecordsDataSet.InvoiceRow invoice)
        {
            disp_client.Text = invoice.ClientRow.clientName;
            disp_date.Text = invoice.orderDate.ToShortDateString();
        }

        private void fillDataGrid(RecordsDataSet.InvoiceRow invoice)
        {
            disp_grid.Rows.Clear();
            initTables();
            
            fillInvoiceNoComboBox();
            input_invoiceNo.Text = invoice.invoiceNo;

            RecordsDataSet.InvoiceItemRow[] rows =
                (from invoiceItem in dbm.db.InvoiceItem
                where invoiceItem.InvoiceRow.Equals(invoice)
                select invoiceItem).ToArray();

            foreach (RecordsDataSet.InvoiceItemRow r in rows)
            {
                disp_grid.Rows.Add(r.ItemRow, r.ItemRow.itemName, r.quantity, r.orderStatus);
            }                       
        }

        private int serveSelectedItems(ServeItemsForm.InputFields mfields)
        {
            string invoiceNoTxt = input_invoiceNo.Text.Trim().ToUpper();


            foreach (DataGridViewRow r in disp_grid.SelectedRows)
            {
                DataGridViewCellCollection c = r.Cells;

                RecordsDataSet.InvoiceItemRow invoice =
                    input_invoiceNo.SelectedItem as RecordsDataSet.InvoiceItemRow;

                int itemId = int.Parse(c["itemId"].Value.ToString());
                int qty = int.Parse(c["quantity"].Value.ToString());

                dbm.db.ItemServed.AddItemServedRow(
                    invoiceNoTxt, itemId, mfields.warehouse.id, qty, mfields.date);
            }

            return disp_grid.SelectedRows.Count;
        }

        private int cancelSelectedItems()
        {
            string invoiceNo = input_invoiceNo.SelectedItem.ToString();

            foreach (DataGridViewRow r in disp_grid.SelectedRows)
            {
                DataGridViewCellCollection c = r.Cells;
                int itemId = int.Parse(c["itemId"].Value.ToString());

                RecordsDataSet.InvoiceItemRow invItem =
                    dbm.db.InvoiceItem.FindByinvoiceNoitemId(invoiceNo, itemId);

                invItem.orderStatus = "CANCELLED";
            }

            return disp_grid.SelectedRows.Count;
        }

        /*
         *  EVENT HANDLERS
         */
        private void input_invoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecordsDataSet.InvoiceRow invoice = input_invoiceNo.SelectedItem as RecordsDataSet.InvoiceRow;
            showInvoiceInfo(invoice);
            fillDataGrid(invoice);
        }

        private void input_invoiceNo_TextChanged(object sender, EventArgs e)
        {
            int index = input_invoiceNo.FindStringExact(input_invoiceNo.Text);
            input_invoiceNo.SelectedIndex = index;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            initTables();
            
            fillInvoiceNoComboBox();
        }

        private void disp_grid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged.Equals(DataGridViewElementStates.Selected) &&
                (e.Row.Cells["orderStatus"].Value.Equals("CANCELLED") || 
                e.Row.Cells["orderStatus"].Value.Equals("SERVED")))
            {
                e.Row.Selected = false;
            }
        }

        private void recordReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (input_invoiceNo.SelectedItem == null)
            {
                MainForm.showErrorMessage("Please select an invoice.");
            }
            else
            {                
                using (ReturnedItemsForm rf = new ReturnedItemsForm())
                {
                    rf.ShowDialog();
                }                    
            }
        }
        
        private void serve_items_option_Click(object sender, EventArgs e)
        {
            if (disp_grid.SelectedRows.Count == 0)
            {
                MainForm.showErrorMessage("No Rows Selected.");
            }
            else
            {
                ServeItemsForm.InputFields inf = new ServeItemsForm.InputFields();
                DialogResult res;

                using (ServeItemsForm sf = new ServeItemsForm(inf))
                {
                    res = sf.ShowDialog();
                }
                
                try
                {
                    int rowsAff = serveSelectedItems(inf);
                                        
                    dbm.dbmgr.UpdateAll(dbm.db);
                    fillDataGrid(input_invoiceNo.SelectedItem as RecordsDataSet.InvoiceRow);

                    MainForm.showSuccessMessage("Operation successful. " + rowsAff + " affected.");
                }
                catch (DBConcurrencyException ex)
                {
                    DialogResult r = MainForm.showErrorPrompt(
                        "An error occured while trying to sync with database.\n\n" + 
                        "Details:\n" + ex.Message);

                    if (r.Equals(DialogResult.Retry))
                    {
                        serve_items_option_Click(sender, e);
                    }
                    else
                    {
                        dbm.db.RejectChanges();
                    }
                }
                catch (Exception ex)
                {
                    dbm.db.RejectChanges();
                    MainForm.showErrorMessage("An error occured.\n\nDetails:\n" + ex.Message);
                }
            }

        }

        private void cancel_items_option_Click(object sender, EventArgs e)
        {
            if (disp_grid.SelectedRows.Count == 0)
            {
                MainForm.showErrorMessage("No Rows Selected.");
            }
            else
            {
                try
                {
                    int rowsAff = cancelSelectedItems();
                    dbm.dbmgr.UpdateAll(dbm.db);

                    fillDataGrid(input_invoiceNo.SelectedItem as RecordsDataSet.InvoiceRow);

                    MainForm.showSuccessMessage("Operation successful. " + rowsAff + " affected.");
                }
                catch (Exception ex)
                {
                    MainForm.showErrorMessage(
                        "An error occured while trying to perform operation.\n\n" +
                        "Details:\n" + ex.Message);
                }
            }
        }
    }
}
