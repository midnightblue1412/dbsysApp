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
    public partial class ReturnedItemsForm : ChildForm
    {
        public ReturnedItemsForm()
        {
            InitializeComponent();
        }

        /*
         *  METHODS
         */
         private void initTables()
        {
            dbm.dbmgr.ClientTableAdapter.Fill(dbm.db.Client);
            dbm.dbmgr.ItemTableAdapter.Fill(dbm.db.Item);
            dbm.dbmgr.InvoiceTableAdapter.Fill(dbm.db.Invoice);
            dbm.dbmgr.InvoiceItemTableAdapter.Fill(dbm.db.InvoiceItem);
            dbm.dbmgr.ItemServedTableAdapter.Fill(dbm.db.ItemServed);
        }

        private void fillItemComboBox()
        {
            RecordsDataSet.ItemRow[] r =
                (from item in dbm.db.ItemServed
                where item.invoiceNo.Equals(disp_invoiceNo.Text)
                select item.ItemInventoryRowParent.ItemRow).ToArray();

            input_itemId.Items.AddRange(r);
        }

        private void fillDataGrid()
        {

        }

        /*
         *  EVENT HANDLERS
         */
        private void ReturnedItemsForm_Load(object sender, EventArgs e)
        {
            initTables();
            fillItemComboBox();
        }

        private void input_itemId_TextChanged(object sender, EventArgs e)
        {
            int index = input_itemId.FindStringExact(input_itemId.Text);
            input_itemId.SelectedIndex = index;
        }

        private void input_itemId_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGrid();
        }
    }
}
