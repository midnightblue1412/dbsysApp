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

            foreach (RecordsDataSet.WarehouseRow r in dbm.db.Warehouse)
            {
                if (r.warehouseStatus.Equals("OP"))
                {
                    input_warehouse.Items.Add(r);
                }
            }   
        }

        public void fillDataGrid()
        {
            disp_ItemInventory.Rows.Clear();

            var a =
                from inv in dbm.db.ItemInventory
                join ret in dbm.db.ReturnsInventory on inv equals ret.ItemInventoryRowParent
                join item in dbm.db.Item on inv.itemId equals item.id
                where inv.WarehouseRow == (RecordsDataSet.WarehouseRow)input_warehouse.SelectedItem
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
            dbm.dbmgr.ItemTableAdapter.Fill(dbm.db.Item);
            dbm.dbmgr.WarehouseTableAdapter.Fill(dbm.db.Warehouse);
            dbm.dbmgr.ItemInventoryTableAdapter.Fill(dbm.db.ItemInventory);
            dbm.dbmgr.ReturnsInventoryTableAdapter.Fill(dbm.db.ReturnsInventory);
            
            fillWarehouseComboBox();
            input_warehouse.SelectedIndex = input_warehouse.Items.Count > 0 ? 0 : -1;

            WindowState = FormWindowState.Maximized;
        }

        private void input_warehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInvoiceForm invForm = new NewInvoiceForm();
            invForm.setParent(this);

            invForm.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invForm = new InvoiceForm();
            invForm.setParent(this);

            invForm.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void warehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
