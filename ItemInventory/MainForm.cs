﻿using System;
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
        internal RegClientsForm regClientsForm;
        internal RegWarehousesForm regWarehousesForm;

        internal AddItemsForm addItemsForm;

        public MainForm()
        {
            InitializeComponent();

            regItemsForm = new RegItemsForm();
            regClientsForm = new RegClientsForm();
            regWarehousesForm = new RegWarehousesForm();

            addItemsForm = new AddItemsForm();
        }

        private void registerItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regItemsForm.ShowDialog();
        }

        private void registerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regClientsForm.ShowDialog();
        }

        private void registerWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regWarehousesForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
