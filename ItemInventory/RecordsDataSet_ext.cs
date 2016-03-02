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
                return id;
            }
        }

        partial class ItemRow
        {
            public override string ToString()
            {
                return this.id;
            }
        }
    }
}
