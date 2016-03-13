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
        public ReturnedItemsForm():this(null) {

        }

        public ReturnedItemsForm(DbForm parent)
        {
            InitializeComponent();
            setParent(parent);
        }

        public ReturnedItemsForm(DbForm parent, string invoiceNo):this(parent)
        {
            disp_invoiceNo.Text = invoiceNo;
            input_date.MinDate = db.Invoice.FindByinvoiceNo(invoiceNo).orderDate;
        }

        /*
         *  METHODS
         */
        private void fillItemComboBox()
        {
            var r =
                from item in db.ItemServed
                where item.invoiceNo.Equals(disp_invoiceNo.Text) &&
                        db.ItemReturned.FindByinvoiceNoitemId(item.invoiceNo, item.itemId) == null                 
                select item.ItemInventoryRowParent.ItemRow;

            input_itemId.Items.AddRange(r.ToArray());
        }

        private void addItem()
        {
            RecordsDataSet.ItemRow r = input_itemId.SelectedItem as RecordsDataSet.ItemRow;

            if (r != null)
            {
                RecordsDataSet.ItemServedRow itemServed =
                db.ItemServed.FindByinvoiceNoitemId(disp_invoiceNo.Text, r.id);
                disp_grid.Rows.Add(
                    r,
                    r.itemName,
                    itemServed.ItemInventoryRowParent.WarehouseRow.warehouseName,
                    itemServed.quantity);

                db.ItemReturned.AddItemReturnedRow(
                    disp_invoiceNo.Text,
                    r.id,
                    itemServed.warehouseId,
                    itemServed.quantity,
                    input_date.Value);
            }
            else
            {
                MainForm.showErrorMessage("Please select an item.");
            }            
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
            fillItemComboBox();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addItem();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (disp_grid.Rows.Count == 0)
            {
                MainForm.showErrorMessage("Form is empty.");
                return;
            }

            try
            {
                recordReturns();

                MainForm p = parent as MainForm;

                MainForm.showSuccessMessage("Operation Successful.");
                Close();
            }
            catch (DBConcurrencyException ex)
            {
                disp_grid.Rows.Clear();
                DialogResult r = MainForm.showErrorPrompt(
                    "An error occured while trying to sync with database.\n\n" +
                    "Details:\n" + ex.Message);

                if (r.Equals(DialogResult.Retry))
                {
                    btn_ok_Click(sender, e);
                }
                else
                {
                    disp_grid.Rows.Clear();
                    db.RejectChanges();
                }
            }
            catch(Exception ex)
            {
                disp_grid.Rows.Clear();
                db.RejectChanges();
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
