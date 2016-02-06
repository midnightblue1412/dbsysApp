using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemInventory
{
    class Utils
    {
        public delegate void RowProcessor(string[] cols);
        public delegate void ErrorCallBack();

        public static string[] getColumnNames(DataGridView dataGrid)
        {
            if (dataGrid.Columns.Count == 0)
            {
                return null;
            }

            string[] cols = new string[dataGrid.Columns.Count];

            int i = 0;
            foreach (DataGridViewColumn c in dataGrid.Columns)
            {
                cols[i] = c.Name;
                i++;
            }

            return cols;
        }

        public static bool rowInputComplete(DataGridViewRow r)
        {
            DataGridViewCellCollection c = r.Cells;
            string[] cols = getColumnNames(r.DataGridView);

            foreach (string col in cols)
            {
                if (c[col].Value == null)
                {
                    r.DataGridView.CurrentCell = c[col];
                    return false;
                }
            }

            return true;
        }        
    }
}
