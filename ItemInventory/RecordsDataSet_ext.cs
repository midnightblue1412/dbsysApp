using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemInventory
{
    partial class RecordsDataSet
    {
        partial class WarehouseRow
        {
            public override string ToString()
            {
                return warehouseName;
            }
        }

        partial class ItemRow
        {
            public override string ToString()
            {
                return itemName;
            }
        }
        
        partial class ClientRow
        {
            public override string ToString()
            {
                return clientName;
            }
        }    

        partial class InvoiceRow
        {
            public override string ToString()
            {
                return invoiceNo;
            }
        }
    }
}
