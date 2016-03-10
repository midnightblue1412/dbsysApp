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
    public partial class ServeItemsForm : ChildForm
    {
        public class InputFields
        {
            internal RecordsDataSet.WarehouseRow warehouse;
            internal DateTime date;
        }

        InputFields input;

        public ServeItemsForm()
        {
            InitializeComponent();
        }

        public ServeItemsForm(InputFields input)
        {
            this.input = input;
        }

        /*
         *  METHODS
         */
         private void initTable()
        {
            dbm.dbmgr.WarehouseTableAdapter.Fill(dbm.db.Warehouse);
        }

        private void fillWarehouseComboBox()
        {
            RecordsDataSet.WarehouseRow[] r = 
                (from warehouse in dbm.db.Warehouse
                where warehouse.warehouseStatus.Equals("OP")
                select warehouse).ToArray();

            input_warehouse.Items.AddRange(r);
        }
        
        /*
         *  EVENT HANDLERS
         */
        private void ServeItemsForm_Load(object sender, EventArgs e)
        {
            initTable();
            fillWarehouseComboBox();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            input.warehouse = input_warehouse.SelectedItem as RecordsDataSet.WarehouseRow;
            input.date = input_date.Value;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
