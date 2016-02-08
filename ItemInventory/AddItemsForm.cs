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
        AppRecordsDataSet.WarehouseRow warehouse;

        public AddItemsForm()
        {
            InitializeComponent();  
        }

        private void initTable()
        {
            dbm.dbmgr.InventoryTableAdapter.Fill(dbm.db.Inventory);
            dbm.dbmgr.InventoryAdditionTableAdapter.Fill(dbm.db.InventoryAddition);
        }

        public void setWarehouse(AppRecordsDataSet.WarehouseRow warehouse)
        {
            this.warehouse = warehouse;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
             
        }

        private void AddItemsForm_Load(object sender, EventArgs e)
        {
            initTable();
        }
    }
}
