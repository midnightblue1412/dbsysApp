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
                    decimal uPrice;

                    if (decimal.TryParse(c["unitPrice"].Value.ToString(), out uPrice)) {
                        dbm.db.Item.AddItemRow(
                        c["id"].Value.ToString(),
                        c["itemName"].Value.ToString(),
                        c["description"].Value.ToString(),
                        uPrice,
                        "AV");
                    }
                    else
                    {
                        input_grid.CurrentCell = c["unitPrice"];
                        throw new Exception("Invalid Unit Price.");
                    }        
                };

                Utils.ErrorCallBack callback = (col) =>
                {
                    MainForm.showErrorMessage("Missing Input in column '" + col + "'");
                    dbm.db.RejectChanges();
                };

                int rowsAdded =
                    Utils.addRowsWithDataGrid(input_grid, Utils.rowInputComplete, proc, callback);

                if (rowsAdded > 0)
                {
                    dbm.dbmgr.ItemTableAdapter.Update(dbm.db.Item);
                    input_grid.Rows.Clear();
                    MainForm.showSuccessMessage(
                        "Successfuly registered " + rowsAdded + " item(s)");
                }
                else if(rowsAdded == 0)
                {
                    MainForm.showErrorMessage("No item(s) were/was registered.");
                }
            }
            catch (Exception ex)
            when (ex is ConstraintException ||
                    ex is DBConcurrencyException ||
                    ex is SqlException ||
                    ex is Exception)
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
                else
                {
                    MainForm.showErrorMessage(ex.Message);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            input_grid.Rows.Clear();
        }
    }
}
