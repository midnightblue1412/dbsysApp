using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ItemInventory.AppRecordsDataSetTableAdapters;

namespace ItemInventory
{
    public class DatabaseModule
    {
        internal readonly AppRecordsDataSet db;
        internal readonly TableAdapterManager dbmgr;
        internal readonly QueriesTableAdapter qadp;

        public DatabaseModule()
        {
            db = new AppRecordsDataSet();
            dbmgr = new TableAdapterManager();
            qadp = new QueriesTableAdapter();

            //Initialize Adapters for Reference Tables
            dbmgr.ClientTableAdapter = new ClientTableAdapter();
            dbmgr.ItemTableAdapter = new ItemTableAdapter();
            dbmgr.WarehouseTableAdapter = new WarehouseTableAdapter();

            //Initialize Adapters for Transaction Tables
            dbmgr.InventoryTableAdapter = new InventoryTableAdapter();
            dbmgr.ReturnsInventoryTableAdapter = new ReturnsInventoryTableAdapter();

            dbmgr.OrderSetTableAdapter = new OrderSetTableAdapter();
            dbmgr.ItemOrderTableAdapter = new ItemOrderTableAdapter();

            dbmgr.InventoryAdditionTableAdapter = new InventoryAdditionTableAdapter();
            dbmgr.ServedItemTableAdapter = new ServedItemTableAdapter();

            dbmgr.ReturnedItemTableAdapter = new ReturnedItemTableAdapter();
            dbmgr.ServedReturnTableAdapter = new ServedReturnTableAdapter();
        }

        public string getItemStatus(string itemId)
        {
            return qadp.GetItemStatus(itemId);
        }

        public DateTime? getOrderDate(string invoiceNo)
        {
            return qadp.GetOrderDate(invoiceNo);
        }

        public string getOrderStatus(string invoiceNo, string itemId)
        {
            return qadp.GetOrderStatus(invoiceNo, itemId);
        }

        public int? getItemQuantity(string warehouseId, string itemId)
        {
            return qadp.GetItemQuantity(warehouseId, itemId);
        }

        public int? getOrderedQuantity(string invoiceNo, string itemId)
        {
            return qadp.GetOrderedQuantity(invoiceNo, itemId);
        }

        public int? getRetInventoryQty(string itemId, string warehouseId)
        {
            return qadp.GetRetInventoryQty(itemId, warehouseId);
        }
    }
}
