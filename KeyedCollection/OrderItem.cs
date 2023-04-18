using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedCollection
{
    public class OrderItem
    {
        public readonly int PartNumber;
        public readonly string Description;        

        public OrderItem(int partNumber, string description)
        {
            this.PartNumber = partNumber;
            this.Description = description;            
        }        
    }
}
