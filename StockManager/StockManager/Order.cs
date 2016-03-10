using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    public class Order
    {
        public int Count { get; set; }
        public string Name { get; set; }

        public bool isFilled { get; set; }

        public Order(string name, int count)
        {
            this.Name = name;
            this.Count = count;

            isFilled = false;
        }

        public void fill(IWarehouse warehouse)
        {
            if (warehouse.hasInventory(Name, Count))
            {
                warehouse.remove(Name, Count);
                isFilled = true;
            }
            else
            {
                isFilled = false;
            }
        }        
    }
}
