using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemInventory
{
    public partial class AddItemsForm : ChildForm
    {
        internal RecordsDataSet.WarehouseRow warehouse;

        public AddItemsForm()
        {
            InitializeComponent();
        }

        /*
         *  METHODS
         */
        public void setWarehouse(RecordsDataSet.WarehouseRow warehouse)
        {
            this.warehouse = warehouse;
        }

        public void fillItemComboBox()
        {
            RecordsDataSet.ItemRow[] items =
                (from item in dbm.db.Item
                where item.itemStatus.Equals("AV")
                select item).ToArray();

            input_itemId.Items.AddRange(items);
        }

        public int findRow(string itemId)
        {
            int i = 0;

            foreach (DataGridViewRow r in disp_grid.Rows)
            {
                DataGridViewCellCollection c = r.Cells;

                if (c["itemId"].Value.ToString().Equals(itemId))
                {
                    return i;
                }

                i++;
            }

            return -1;
        }

        private int updateDataSet()
        {
            foreach (DataGridViewRow r in disp_grid.Rows)
            {
                DataGridViewCellCollection c = r.Cells;
                string itemIdStr = c["itemId"].Value.ToString();
                int quantity = int.Parse(c["quantity"].Value.ToString());

                RecordsDataSet.ItemInventoryRow inventoryRow =
                    dbm.db.ItemInventory.FindBywarehouseIditemId(warehouse.id, itemIdStr);

                if (inventoryRow != null)
                {
                    inventoryRow.quantity += quantity;
                }
                else
                {
                    dbm.db.ItemInventory.AddItemInventoryRow(
                        warehouse,
                        dbm.db.Item.FindByid(itemIdStr),
                        quantity);
                }
            }

            return disp_grid.Rows.Count;
        }

        private void initTable()
        {
            dbm.dbmgr.ItemInventoryTableAdapter.Fill(dbm.db.ItemInventory);           
        }

        /*
         *  EVENT HANDLERS
         */
        private void AddItemsForm_Load(object sender, EventArgs e)
        {
            disp_warehouse.Text = warehouse.ToString() ;
            fillItemComboBox();
        }

        private void input_itemId_TextChanged(object sender, EventArgs e)
        {
            int index = input_itemId.FindStringExact(input_itemId.Text);
            input_itemId.SelectedIndex = index;

            if (index >= 0)
            {
                input_qty.Value = 1;
            }
            else
            {
                input_qty.Value = 0;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int index = findRow(input_itemId.Text);

            if (input_itemId.SelectedIndex < 0)
            {
                MainForm.showErrorMessage("No Item Selected.");
            }
            else if (input_qty.Value < 1)
            {
                MainForm.showErrorMessage("Quantity must be greater than 0");
            }
            else if (index >= 0)
            {
                disp_grid.Rows[index].Cells["quantity"].Value = input_qty.Value;
            }
            else
            {
                RecordsDataSet.ItemRow r = input_itemId.SelectedItem as RecordsDataSet.ItemRow;
                disp_grid.Rows.Add(r, r.itemName, input_qty.Value);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            disp_grid.Rows.Clear();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                LoadingPrompt l = new LoadingPrompt("Processing Request...");
                int rowsAdded = updateDataSet();       

                if (rowsAdded > 0)
                {
                    dbm.dbmgr.ItemInventoryTableAdapter.Update(dbm.db);
                    dbm.dbmgr.ReturnsInventoryTableAdapter.Fill(dbm.db.ReturnsInventory);
                    ((MainForm)parent).fillDataGrid();
                    MainForm.showSuccessMessage("Successfuly updated " + rowsAdded + " item(s) in inventory.");
                }
                else
                {
                    dbm.db.RejectChanges();
                    MainForm.showErrorMessage("No item(s) were updated in inventory.");
                }
            }
            catch (Exception ex)
            when (ex is ConstraintException ||
                    ex is DBConcurrencyException ||
                    ex is SqlException ||
                    ex is Exception)
            {
                dbm.db.RejectChanges();

                if (ex is ConstraintException)
                {
                    MainForm.showErrorMessage(
                    "A constraint was violated while trying to " +
                    "add item(s).\n\nDetails:\n" + ex.Message);
                }
                else if (ex is DBConcurrencyException ||
                            ex is SqlException)
                {
                    initTable();
                    btn_ok_Click(sender, e);
                }
                else
                {
                    MainForm.showErrorMessage(ex.Message);
                }
            }

            this.Dispose();
        }
    }
}
