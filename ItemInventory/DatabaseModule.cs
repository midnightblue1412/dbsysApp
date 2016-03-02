using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ItemInventory.RecordsDataSetTableAdapters;

namespace ItemInventory
{
    public class DatabaseModule
    {
        internal readonly RecordsDataSet db;
        internal readonly TableAdapterManager dbmgr;
        internal readonly QueriesTableAdapter qadp;

        public DatabaseModule()
        {
            db = new RecordsDataSet();
            dbmgr = new TableAdapterManager();
            qadp = new QueriesTableAdapter();

            //Initialize Adapters for Reference Tables
            dbmgr.ClientTableAdapter = new ClientTableAdapter();
            dbmgr.ItemTableAdapter = new ItemTableAdapter();
            dbmgr.WarehouseTableAdapter = new WarehouseTableAdapter();

            //Initialize Adapters for Transaction Tables
            dbmgr.ItemInventoryTableAdapter = new ItemInventoryTableAdapter();
            dbmgr.ReturnsInventoryTableAdapter = new ReturnsInventoryTableAdapter();
            
            dbmgr.ItemReturnedTableAdapter = new ItemReturnedTableAdapter();

            dbmgr.InvoiceTableAdapter = new InvoiceTableAdapter();
            dbmgr.InvoiceItemTableAdapter = new InvoiceItemTableAdapter();

            dbmgr.InventoryMovementTableAdapter = new InventoryMovementTableAdapter();
            dbmgr.ItemServedTableAdapter = new ItemServedTableAdapter();

            dbmgr.ItemReturnedTableAdapter = new ItemReturnedTableAdapter();
            dbmgr.ReturnServedTableAdapter = new ReturnServedTableAdapter();
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
            return qadp.GetRetItemQuantity(itemId, warehouseId);
        }
    }
}
