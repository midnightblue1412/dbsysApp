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
        public SelectWarehouseForm(AddItemsForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void SelectWarehouseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Close();            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Close();
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            object warehouseId = input_warehouseId.SelectedItem;
            if (warehouseId != null)
            {
                ((AddItemsForm)parent).warehouseId = warehouseId.ToString();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Please Select a Warehouse",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
