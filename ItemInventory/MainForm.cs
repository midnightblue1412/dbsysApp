using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemInventory
{
    public partial class MainForm : DbForm
    {
        public MainForm()
        {
            //SET CURRENT LOCALE TO PHILIPPINES (TO USE PESO AS CURRENCY)
            System.Globalization.CultureInfo c = new System.Globalization.CultureInfo("en-PH");
            System.Threading.Thread.CurrentThread.CurrentCulture = c;

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
        
        internal static DialogResult showErrorPrompt(string v)
        {
            return MessageBox.Show(v, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        public void fillWarehouseComboBox()
        {
            input_warehouse.Items.Clear();

            foreach (RecordsDataSet.WarehouseRow r in db.Warehouse)
            {
                if (r.warehouseStatus.Equals("OP"))
                {
                    input_warehouse.Items.Add(r);
                }
            }   
        }

        public void fillInventoryGrid(int wid)
        {
            disp_ItemInventory.Rows.Clear();

            var a =
                from inv in db.ItemInventory
                join ret in db.ReturnsInventory 
                    on new{ inv.warehouseId, inv.itemId} equals new { ret.warehouseId, ret.itemId}
                join item in db.Item on inv.itemId equals item.id
                where inv.WarehouseRow == db.Warehouse.FindByid(wid)
                orderby inv.itemId
                select new
                {
                    inv.itemId,
                    item.itemName,
                    qty = inv.quantity,
                    qty_ret = ret.quantity
                };

            foreach (var r in a)
            {
                disp_ItemInventory.Rows.Add(r.itemId, r.itemName, r.qty, r.qty_ret);
            }
        }

        internal void fillWarehouseGrid()
        {
            Utils.fillDataGrid(db.Warehouse, disp_grid_warehouse);
        }

        internal void fillItemGrid()
        {
            Utils.fillDataGrid(db.Item, disp_grid_item);
        }

        internal void fillClientGrid()
        {
            Utils.fillDataGrid(db.Client, disp_grid_client);
        }
        
        internal void fillHistoryGrid()
        {
            disp_grid_history.Rows.Clear();

            dbmgr.InventoryMovementTableAdapter.Fill(db.InventoryMovement);
            var a = from invm in db.InventoryMovement
                    join item in db.Item on invm.itemId equals item.id
                    join warehouse in db.Warehouse on invm.warehouseId equals warehouse.id
                    select new { invm.refno, invm.movDate, warehouse.warehouseName, item.itemName, invm.quantity };

            foreach (var r in a)
            {
                disp_grid_history.Rows.Add(r.refno, r.movDate, r.warehouseName, r.itemName, r.quantity);
            }
        }

        public void refreshWarehouseComboBox()
        {
            string wname = input_warehouse.Text;
            fillWarehouseComboBox();
            input_warehouse.SelectedIndex = input_warehouse.FindStringExact(wname);
        }

        /*
         * EVENT HANDLERS
         */
        private void btn_registerItems_Click(object sender, EventArgs e)
        {
            using (RegItemsForm regItemsForm = new RegItemsForm())
            {
                regItemsForm.setParent(this);
                regItemsForm.ShowDialog();
            }                
        }

        private void btn_registerClients_Click(object sender, EventArgs e)
        {
            using (RegClientsForm regClientsForm = new RegClientsForm())
            {
                regClientsForm.setParent(this);
                regClientsForm.ShowDialog();
            }            
        }

        private void btn_registerWarehouse_Click(object sender, EventArgs e)
        {
            using (RegWarehousesForm regWarehousesForm = new RegWarehousesForm())
            {
                regWarehousesForm.setParent(this);
                regWarehousesForm.initTable();
                regWarehousesForm.ShowDialog();
            }                
        }

        private void btn_addItems_Click(object sender, EventArgs e)
        {
            AddItemsForm af;
            using (af = new AddItemsForm())
            {
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
        }

        internal void inv_setSelectedWarehouse(string wname)
        {
            input_warehouse.SelectedIndex = input_warehouse.FindStringExact(wname);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dbm.initAllTables();

            fillWarehouseComboBox();
            input_warehouse.SelectedIndex = input_warehouse.Items.Count > 0 ? 0 : -1;

            WindowState = FormWindowState.Maximized;
        }

        private void input_warehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecordsDataSet.WarehouseRow w = input_warehouse.SelectedItem as RecordsDataSet.WarehouseRow;
            fillInventoryGrid(w.id);
        }

        private void btn_newInvoice_Click(object sender, EventArgs e)
        {
            using (NewInvoiceForm invForm = new NewInvoiceForm())
            {
                invForm.setParent(this);

                invForm.ShowDialog();
            }
        }
        
        private void tab_Invoices_Enter(object sender, EventArgs e)
        {
            dbm.initAllTables();
            refreshWarehouseComboBox();
            refreshInvoiceNoComboBox();
        }

        private void tab_warehouses_Enter(object sender, EventArgs e)
        {
            fillWarehouseGrid();
        }

        private void tab_items_Enter(object sender, EventArgs e)
        {
            fillItemGrid();
        }

        private void tab_clients_Enter(object sender, EventArgs e)
        {
            fillClientGrid();
        }

        private void tab_history_Enter(object sender, EventArgs e)
        {
            fillHistoryGrid();
        }

        private void tab_Inventory_Enter(object sender, EventArgs e)
        {
            dbm.initAllTables();
            refreshWarehouseComboBox();        
        }
    }
}
