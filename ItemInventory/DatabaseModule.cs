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

        public void initAllTables()
        {
            dbmgr.ClientTableAdapter.Fill(db.Client);
            dbmgr.ItemTableAdapter.Fill(db.Item);
            dbmgr.WarehouseTableAdapter.Fill(db.Warehouse);

            dbmgr.ItemInventoryTableAdapter.Fill(db.ItemInventory);
            dbmgr.ReturnsInventoryTableAdapter.Fill(db.ReturnsInventory);

            dbmgr.ItemReturnedTableAdapter.Fill(db.ItemReturned);

            dbmgr.InvoiceTableAdapter.Fill(db.Invoice);
            dbmgr.InvoiceItemTableAdapter.Fill(db.InvoiceItem);

            dbmgr.InventoryMovementTableAdapter.Fill(db.InventoryMovement);
            dbmgr.ItemServedTableAdapter.Fill(db.ItemServed);

            dbmgr.ItemReturnedTableAdapter.Fill(db.ItemReturned);
            dbmgr.ReturnServedTableAdapter.Fill(db.ReturnServed);
        }

        public string getItemStatus(int? itemId)
        {
            return qadp.GetItemStatus(itemId);
        }

        public DateTime? getOrderDate(string invoiceNo)
        {
            return qadp.GetOrderDate(invoiceNo);
        }

        public DateTime? getServeDate(string invoiceNo, int? itemId)
        {
            return qadp.GetServeDate(invoiceNo, itemId);
        }

        public string getOrderStatus(string invoiceNo, int? itemId)
        {
            return qadp.GetOrderStatus(invoiceNo, itemId);
        }

        public int? getItemQuantity(int? warehouseId, int? itemId)
        {
            return qadp.GetItemQuantity(warehouseId, itemId);
        }

        public int? getOrderedQuantity(string invoiceNo, int? itemId)
        {
            return qadp.GetOrderedQuantity(invoiceNo, itemId);
        }

        public int? getPendingQuantity(string invoiceNo, int? itemId)
        {
            return qadp.GetPendingQuantity(invoiceNo, itemId);
        }

        public int? getReturnedQuantity(string invoiceNo, int? itemId)
        {
            return qadp.GetReturnedQuantity(invoiceNo, itemId);
        }

        public int? getRetInventoryQty(int? warehouseId, int? itemId)
        {
            return qadp.GetRetItemQuantity(warehouseId, itemId);
        }
    }
}
