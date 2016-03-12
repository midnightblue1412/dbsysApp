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
        public class InvalidPriceException : Exception
        {
            public InvalidPriceException(string message) : base(message) { }
        }

        public RegItemsForm()
        {
            InitializeComponent();
        }

        internal void initTable()
        {
            dbm.dbmgr.ItemTableAdapter.Fill(db.Item);
        }
        
        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAdded = addToDataSet();

                if (rowsAdded > 0)
                {
                    dbm.dbmgr.ItemTableAdapter.Update(dbm.db);
                    MainForm.showSuccessMessage("Successfuly registered " + rowsAdded + " item(s).");
                    MainForm p = parent as MainForm;
                    p.fillItemGrid();
                    Close();
                }
                else {
                    db.Item.RejectChanges();
                    MainForm.showErrorMessage("Failed to register item(s).");                        
                }                
            }
            catch (Exception ex)
            when (ex is ConstraintException ||
                    ex is DBConcurrencyException ||
                    ex is SqlException ||
                    ex is InvalidPriceException)
            {
                db.RejectChanges();

                if (ex is ConstraintException)
                {
                    MainForm.showErrorMessage(
                    "A constraint was violated while trying to " +
                    "register item(s).\n\nDetails:\n" + ex.Message);
                }
                else if (ex is DBConcurrencyException ||
                            ex is SqlException)
                {       
                    initTable();
                    btn_register_Click(sender, e);
                }
                else
                {
                    MainForm.showErrorMessage(ex.Message);
                }
            }
        }

        private int addToDataSet()
        {
            Utils.RowProcessor proc = (c) =>
            {
                decimal uPrice;

                if (decimal.TryParse(c["unitPrice"].Value.ToString(), out uPrice))
                {
                    db.Item.AddItemRow(
                    c["itemName"].Value.ToString(),
                    c["description"].Value.ToString(),
                    uPrice,
                    "AV");
                }
                else
                {
                    input_grid.CurrentCell = c["unitPrice"];
                    throw new InvalidPriceException("Invalid Unit Price.");
                }
            };

            Utils.ErrorCallBack callback = (col) =>
            {
                MainForm.showErrorMessage("Missing Input in column '" + col + "'");
                db.RejectChanges();
            };

            int rowsAdded =
                Utils.addRowsWithDataGrid(input_grid, Utils.rowInputComplete, proc, callback);

            return rowsAdded;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            input_grid.Rows.Clear();
        }
    }
}
