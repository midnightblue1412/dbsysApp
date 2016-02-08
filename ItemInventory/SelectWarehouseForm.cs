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
    public partial class SelectWarehouseForm : ChildForm
    {
        private AppRecordsDataSet.WarehouseRow selectedWarehouse;

        public AppRecordsDataSet.WarehouseRow Warehouse
        {
            get
            {
                return selectedWarehouse;
            }
        }

        public SelectWarehouseForm()
        {
            InitializeComponent();
        }
        
        internal void initTable()
        {
            dbm.dbmgr.WarehouseTableAdapter.Fill(dbm.db.Warehouse);
        }

        private void SelectWarehouseForm_Load(object sender, EventArgs e)
        {
            initTable();

            AppRecordsDataSet.WarehouseRow[] warehouses =
                (from warehouse in dbm.db.Warehouse
                where warehouse.warehouseStatus.ToUpper().Equals("OP")
                select warehouse).ToArray();

            MainForm.showSuccessMessage("retrieved data: " + warehouses.Count());

            input_warehouseId.Items.AddRange(warehouses);
        }
        
        private void btn_proceed_Click(object sender, EventArgs e)
        {
            selectedWarehouse = (AppRecordsDataSet.WarehouseRow)input_warehouseId.SelectedItem;

            if (selectedWarehouse == null)
            {
                MainForm.showErrorMessage("Select a warehouse first!");
            }
            else
            {
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void autoSelect(object sender, EventArgs e)
        {
            int index = input_warehouseId.FindStringExact(input_warehouseId.Text.Trim());
            input_warehouseId.SelectedIndex = index;
        }

        private void inputHelper(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                int index = input_warehouseId.FindString(input_warehouseId.Text.Trim());
                input_warehouseId.SelectedIndex = index;
            }
        }
    }
}
