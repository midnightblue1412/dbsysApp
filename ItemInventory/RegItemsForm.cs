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

    }
}
