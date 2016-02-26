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

        private void addToDataSet()
        {
            Utils.RowProcessor proc = (c) =>
            {
                dbm.db.ItemInventory.AddItemInventoryRow(
                    warehouse,
                    c["itemId"].Value as RecordsDataSet.ItemRow,
                    int.Parse(c["quantity"].Value.ToString()));            
            };

            Utils.ErrorCallBack callback = (col) =>
            {
                //TODO: fully implement add items form
            };            
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            disp_grid.Rows.Clear();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
