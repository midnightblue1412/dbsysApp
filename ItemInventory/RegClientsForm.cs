using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemInventory
{
    public partial class RegClientsForm : ChildForm
    {
        public RegClientsForm()
        {
            InitializeComponent();
        }

        internal void initTable()
        {
            dbm.dbmgr.ClientTableAdapter.Fill(db.Client);
        }
        
        private void RegClientsForm_Load(object sender, EventArgs e)
        {
            initTable();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            input_grid.Rows.Clear();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.RowProcessor proc = (c) =>
                {
                    db.Client.AddClientRow(
                        c["clientName"].Value.ToString().Trim().ToUpper(),
                        c["clientAddress"].Value.ToString().Trim().ToUpper(),
                        "AC");
                };

                Utils.ErrorCallBack callback = (col) =>
                {
                    MainForm.showErrorMessage("Missing Input in column '" + col + "'");
                    db.RejectChanges();
                };

                int rowsAdded =
                    Utils.addRowsWithDataGrid(input_grid, Utils.rowInputComplete, proc, callback);

                if (rowsAdded > 0)
                {
                    dbm.dbmgr.ClientTableAdapter.Update(db.Client);
                    input_grid.Rows.Clear();

                    MainForm p = parent as MainForm;
                    p.fillClientGrid();

                    MainForm.showSuccessMessage(
                        "Successfuly registered " + rowsAdded + " client(s)");
                    
                    Close();
                }
                else if(rowsAdded == 0)
                {
                    MainForm.showErrorMessage("No client(s) was/were registered.");                       
                }
            }
            catch (Exception ex)
            when (ex is ConstraintException ||
                    ex is DBConcurrencyException ||
                    ex is SqlException)
            {
                db.RejectChanges();

                if (ex is ConstraintException)
                {
                    MainForm.showErrorMessage(
                    "A constraint was violated while trying to " +
                    "register client(s).\n\nDetails:\n" + ex.Message);
                }
                else if (ex is DBConcurrencyException ||
                            ex is SqlException)
                {
                    MainForm.showErrorMessage(
                    "An error occured while trying to sync with database.\n" +
                    "Please try again.\n\nDetails:\n" + ex.Message);

                    initTable();
                }
            }
        }
    }
}
