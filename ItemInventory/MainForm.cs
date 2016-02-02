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
            AddItemsForm addItemsForm = new AddItemsForm();
            if(!addItemsForm.IsDisposed)
            {
                addItemsForm.setParent(this);
                addItemsForm.ShowDialog();
            }
        }

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
    }
}
