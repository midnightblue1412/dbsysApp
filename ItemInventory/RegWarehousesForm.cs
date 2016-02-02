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
    public partial class RegWarehousesForm : ChildForm
    {
        public RegWarehousesForm()
        {
            InitializeComponent();
        }

        internal void initTable()
        {
            dbm.dbmgr.WarehouseTableAdapter.Fill(dbm.db.Warehouse);
        }

        private bool isInputComplete(DataGridViewRow r)
        {
            DataGridViewCellCollection c = r.Cells;
            if (c["id"].Value == null)
            {
                r.DataGridView.CurrentCell = c["id"];
            }
            else if (c["warehouseName"].Value == null)
            {
                r.DataGridView.CurrentCell = c["warehouseName"];
            }
            else if (c["description"].Value == null)
            {
                r.DataGridView.CurrentCell = c["description"];
            }
            else
            {
                return true;
            }

            return false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow lastRow = input_grid.Rows[input_grid.Rows.Count - 1];

                foreach (DataGridViewRow r in input_grid.Rows)
                {
                    if (isInputComplete(r))
                    {
                        DataGridViewCellCollection c = r.Cells;
                        dbm.db.Warehouse.AddWarehouseRow(
                            c["id"].Value.ToString(),
                            c["warehouseName"].Value.ToString(),
                            c["description"].Value.ToString(),
                            "OP");
                    }
                    else if(r != lastRow)
                    {
                        MainForm.showErrorMessage("Missing Input!");
                        dbm.db.RejectChanges();
                        return;
                    }                                              
                }

                dbm.dbmgr.WarehouseTableAdapter.Update(dbm.db.Warehouse);

                MainForm.showSuccessMessage("Successfuly registered warehouse(s)");
            }
            catch (ConstraintException ex)
            {
                MainForm.showErrorMessage("[Constriant Violation] " + ex.Message);
                dbm.db.RejectChanges();
            }
            catch (Exception ex)
            {
                MainForm.showErrorMessage("[Error] " + ex.Message);
                dbm.db.RejectChanges();
            }
        }
    }
}
