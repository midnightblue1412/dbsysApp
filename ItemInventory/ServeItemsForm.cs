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

        public ServeItemsForm() : this(null, null) { }

        public ServeItemsForm(InputFields input, DbForm parent):base(parent)
        {
            InitializeComponent();
            this.input = input;
        }

        /*
         *  METHODS
         */
        public void setInvoice(string invoiceNo)
        {
            DateTime odate = (DateTime)dbm.qadp.GetOrderDate(invoiceNo);
            input_date.MinDate = odate.AddDays(1);
        }

        public void useInput(InputFields input)
        {
            this.input = input;
        }

        private void fillWarehouseComboBox()
        {
            RecordsDataSet.WarehouseRow[] r = 
                (from warehouse in db.Warehouse
                where warehouse.warehouseStatus.Equals("OP")
                select warehouse).ToArray();

            input_warehouse.Items.AddRange(r);
        }
        
        /*
         *  EVENT HANDLERS
         */
        private void ServeItemsForm_Load(object sender, EventArgs e)
        {
            fillWarehouseComboBox();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            RecordsDataSet.WarehouseRow wh = input_warehouse.SelectedItem as RecordsDataSet.WarehouseRow;
            if (wh == null)
            {
                MainForm.showErrorMessage("Select Warehouse First.");
            }
            else
            {
                input.warehouse = input_warehouse.SelectedItem as RecordsDataSet.WarehouseRow;
                input.date = input_date.Value;

                DialogResult = DialogResult.OK;

                Close();
            }            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
