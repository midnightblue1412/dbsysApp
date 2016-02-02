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
    public partial class ChildForm :Form
    {
        protected DatabaseModule dbm;
        protected Form parent;

        public void setParent(DbForm parent)
        {
            this.parent = parent;
            dbm = parent.dbm;
        }

        public ChildForm()
        {
            InitializeComponent();
        }
    }
}
