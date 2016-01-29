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
    public partial class AddItemsForm : Form
    {
        internal SelectWarehouseForm sel;

        public AddItemsForm()
        {
            InitializeComponent();
            sel = new SelectWarehouseForm();
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
            sel.ShowDialog();
        }
    }
}
