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
        private RecordsDataSet.WarehouseRow wh;
        private DateTime date;

        public ReturnedItemsForm()
        {
            InitializeComponent();
        }

        public ReturnedItemsForm(string invoiceNo):this()
        {
            disp_invoiceNo.Text = invoiceNo;
        }

        public ReturnedItemsForm(string invoiceNo, ref RecordsDataSet.WarehouseRow wh, ref DateTime date) : this(invoiceNo)
        {
            this.wh = wh;
            this.date = date;
        }

        /*
         *  METHODS
         */
        private void initTables()
        {
            dbm.dbmgr.ClientTableAdapter.Fill(dbm.db.Client);
            dbm.dbmgr.ItemTableAdapter.Fill(dbm.db.Item);
            dbm.dbmgr.WarehouseTableAdapter.Fill(dbm.db.Warehouse);

            dbm.dbmgr.ItemInventoryTableAdapter.Fill(dbm.db.ItemInventory);

            dbm.dbmgr.InvoiceTableAdapter.Fill(dbm.db.Invoice);
            dbm.dbmgr.InvoiceItemTableAdapter.Fill(dbm.db.InvoiceItem);

            dbm.dbmgr.ItemServedTableAdapter.Fill(dbm.db.ItemServed);
            dbm.dbmgr.ItemReturnedTableAdapter.Fill(dbm.db.ItemReturned);
        }

        private void fillItemComboBox()
        {
            var r =
                from item in dbm.db.ItemServed
                where item.invoiceNo.Equals(disp_invoiceNo.Text)
                select item.ItemInventoryRowParent.ItemRow;

            input_itemId.Items.AddRange(r.ToArray());
        }

        private void addItem()
        {
            RecordsDataSet.ItemRow r = input_itemId.SelectedItem as RecordsDataSet.ItemRow;
            RecordsDataSet.ItemServedRow itemServed =
                dbm.db.ItemServed.FindByinvoiceNoitemId(disp_invoiceNo.Text, r.id);
            disp_grid.Rows.Add(
                r,
                r.itemName,
                itemServed.ItemInventoryRowParent.WarehouseRow.warehouseName,
                itemServed.quantity);

            dbm.db.ItemReturned.AddItemReturnedRow(
                disp_invoiceNo.Text,
                r.id,
                itemServed.warehouseId,
                itemServed.quantity,
                input_date.Value);
        }

        private void recordReturns()
        {
            dbm.dbmgr.UpdateAll(dbm.db);
        }

        /*
         *  EVENT HANDLERS
         */
        private void ReturnedItemsForm_Load(object sender, EventArgs e)
        {
            initTables();
            fillItemComboBox();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addItem();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                recordReturns();
                Close();
            }
            catch (DBConcurrencyException ex)
            {
                DialogResult r = MainForm.showErrorPrompt(
                    "An error occured while trying to sync with database.\n\n" +
                    "Details:\n" + ex.Message);

                if (r.Equals(DialogResult.Retry))
                {
                    btn_ok_Click(sender, e);
                }
                else
                {
                    dbm.db.RejectChanges();
                }
            }
            catch(Exception ex)
            {
                dbm.db.RejectChanges();
                MainForm.showErrorMessage(
                    "An Error occured.\nDetails:\n\n" + ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void input_itemId_TextChanged(object sender, EventArgs e)
        {
            int index = input_itemId.FindStringExact(input_itemId.Text);
            input_itemId.SelectedIndex = index;
        }
    }
}
