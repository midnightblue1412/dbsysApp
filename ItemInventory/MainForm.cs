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
    public partial class MainForm : DbForm
    {
        public MainForm()
        {
            InitializeComponent();            
        }
        
        /*
         * METHODS
         */
        public static void showSuccessMessage(string msg)
        {
            MessageBox.Show(
                msg,
                "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void showErrorMessage(string msg)
        {
            MessageBox.Show(
                msg,
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public void fillWarehouseComboBox()
        {
            input_warehouse.Items.Clear();

            foreach (RecordsDataSet.WarehouseRow r in dbm.db.Warehouse)
            {
                if (r.warehouseStatus.Equals("OP"))
                {
                    input_warehouse.Items.Add(r);
                }
            }   
        }

        /*
         * EVENT HANDLERS
         */
        private void registerItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegItemsForm regItemsForm = new RegItemsForm();
            regItemsForm.setParent(this);
            regItemsForm.ShowDialog();
        }

        private void registerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegClientsForm regClientsForm = new RegClientsForm();
            regClientsForm.setParent(this);
            regClientsForm.ShowDialog();
        }

        private void registerWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegWarehousesForm regWarehousesForm = new RegWarehousesForm();
            regWarehousesForm.setParent(this);
            regWarehousesForm.initTable();
            regWarehousesForm.ShowDialog();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemsForm af = new AddItemsForm();
            af.setParent(this);

            RecordsDataSet.WarehouseRow warehouse =
                input_warehouse.SelectedItem as RecordsDataSet.WarehouseRow;

            if (warehouse != null)
            {
                af.setWarehouse(warehouse);
                af.ShowDialog();
            }
            else
            {
                showErrorMessage("No Warehouse Selected.");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fillWarehouseComboBox();
        }

        private void input_warehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecordsDataSet.InventoryUIRow[] inventory =
                (from itemInventory in dbm.db.InventoryUI
                where itemInventory.warehouseId == 
                    (input_warehouse.SelectedItem as RecordsDataSet.WarehouseRow).id
                select itemInventory).ToArray();

            foreach (RecordsDataSet.InventoryUIRow r in inventory)
            {
                disp_ItemInventory.Rows.Add(r.id, r.itemName, r.quantity);
            }
        }
    }
}
