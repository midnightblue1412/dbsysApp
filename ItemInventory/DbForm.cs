﻿using ItemInventory.RecordsDataSetTableAdapters;
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
    public partial class DbForm : System.Windows.Forms.Form
    {
        internal readonly DatabaseModule dbm;

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

        public DbForm()
        {
            InitializeComponent();
            dbm = new DatabaseModule();
        }
    }
}
