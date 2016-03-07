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

            RecordsDataSet.InvoiceItemRow[] rows =
                (from invoiceItem in dbm.db.InvoiceItem
                where invoiceItem.InvoiceRow.Equals(invoice)
                select invoiceItem).ToArray();

            foreach (RecordsDataSet.InvoiceItemRow r in rows)
            {
                disp_grid.Rows.Add(r.ItemRow, r.ItemRow.itemName, r.quantity, r.orderStatus);
            }                       
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
            //TODO: IMPLEMENT RETURNS RECORDING
        }
        
        private void serve_items_option_Click(object sender, EventArgs e)
        {
            if (disp_grid.SelectedRows.Count == 0)
            {
                MainForm.showErrorMessage("No Rows Selected.");
            }
            else
            {
                //TODO: IMPLEMENT SERVE ITEMS
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
                //TODO: IMLEMENT CANCEL ITEMS
            }
        }
    }
}
