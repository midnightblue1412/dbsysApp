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
    public partial class RegItemsForm : ChildForm
    {
        public RegItemsForm()
        {
            InitializeComponent();
        }

        internal void initTable()
        {
            dbm.dbmgr.ItemTableAdapter.Fill(dbm.db.Item);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.RowProcessor proc = (c) =>
                {
                    dbm.db.Item.AddItemRow(
                        c["id"].Value.ToString(),
                        c["itemName"].Value.ToString(),
                        c["description"].Value.ToString(),
                        //c["unitPrice"].Value.ToString(),
                        "AV");
                };

                Utils.ErrorCallBack callback = (col) =>
                {
                    MainForm.showErrorMessage("Missing Input in column '" + col + "'");
                    dbm.db.RejectChanges();
                };

                bool rowsAdded =
                    Utils.addRowsWithDataGrid(input_grid, Utils.rowInputComplete, proc, callback);

                if (rowsAdded)
                {
                    dbm.dbmgr.ItemTableAdapter.Update(dbm.db.Item);
                    MainForm.showSuccessMessage("Successfuly registered item(s)");
                }
            }
            catch (Exception ex)
            when (ex is ConstraintException ||
                    ex is DBConcurrencyException ||
                    ex is SqlException)
            {
                dbm.db.RejectChanges();

                if (ex is ConstraintException)
                {
                    MainForm.showErrorMessage(
                    "A constraint was violated while trying to " +
                    "register item(s).\n\nDetails:\n" + ex.Message);
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            input_grid.Rows.Clear();
        }
    }
}
