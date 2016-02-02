using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ItemInventory.AppRecordsDataSetTableAdapters;

namespace ItemInventory
{
    class DatabaseModule
    {
        internal AppRecordsDataSet db;
        internal TableAdapterManager dbmgr;

        public DatabaseModule()
        {
            db = new AppRecordsDataSet();
            dbmgr = new TableAdapterManager();

            //Initialize Adapters for Reference Tables
            dbmgr.ClientTableAdapter = new ClientTableAdapter();
            dbmgr.ItemTableAdapter = new ItemTableAdapter();
            dbmgr.WarehouseTableAdapter = new WarehouseTableAdapter();

            //Initialize Adapters for Transaction Tables
            dbmgr.InventoryTableAdapter = new InventoryTableAdapter();
            dbmgr.ReturnsInventoryTableAdapter = new ReturnsInventoryTableAdapter();

            dbmgr.OrderSetTableAdapter = new OrderSetTableAdapter();
            dbmgr.ItemOrderTableAdapter = new ItemOrderTableAdapter();

            dbmgr.InventoryChangesTableAdapter = new InventoryChangesTableAdapter();
            dbmgr.ReturnsInventoryChangesTableAdapter = new ReturnsInventoryChangesTableAdapter();
        }
    }
}
