using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ItemInventory.RecordsDataSetTableAdapters;

namespace ItemInventory
{
    public partial class ChildForm : System.Windows.Forms.Form
    {
        protected DatabaseModule dbm;
        protected System.Windows.Forms.Form parent;

        public RecordsDataSet db
        {
            get
            {
                return dbm.db;
            }
        }

        public TableAdapterManager dbmgr
        {
            get
            {
                return dbm.dbmgr;
            }
        }

        public void setParent(DbForm parent)
        {
            this.parent = parent;
            dbm = parent.dbm;
        }

        public ChildForm()
        {
            InitializeComponent();
        }

        public ChildForm(DbForm parent) : this()
        {
            this.parent = parent;
            dbm = parent.dbm;
        }
    }
}
