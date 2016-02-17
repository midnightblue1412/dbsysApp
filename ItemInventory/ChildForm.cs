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
    public partial class ChildForm : System.Windows.Forms.Form
    {
        protected DatabaseModule dbm;
        protected System.Windows.Forms.Form parent;

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
