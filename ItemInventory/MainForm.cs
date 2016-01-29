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
    public partial class MainForm : Form
    {
        internal RegItemsForm regItemsForm;

        public MainForm()
        {
            InitializeComponent();
            regItemsForm = new RegItemsForm();
        }

        private void registerItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regItemsForm.ShowDialog();
        }
    }
}
