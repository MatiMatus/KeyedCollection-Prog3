using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedCollection
{
    public class SimpleOrder : KeyedCollection<int, OrderItem >
    {
        protected override int GetKeyForItem(OrderItem item)
        {
            return item.PartNumber;
        }
        internal void ChangeKey(OrderItem item, int newKey)
        {
            base.ChangeItemKey(item, newKey);
        }
    }
}
