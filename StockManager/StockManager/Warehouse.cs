using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    public class Warehouse : IWarehouse
    {
        private Dictionary<string, int> stock;

        public Warehouse()
        {
            stock = new Dictionary<string, int>();
        }

        public void add(string name, int count)
        {
            if (stock.ContainsKey(name))
            {
                stock[name] += count;
            }
            else
            {
                stock.Add(name, count);
            }
        }

        public void remove(string name, int count)
        {
            if (stock.ContainsKey(name))
            {
                stock[name] -= count;
            }
        }

        public bool hasInventory(string name, int count)
        {
            return getInventory(name) >= count;
        }

        public int getInventory(string name)
        {
            if (stock.ContainsKey(name))
            {
                return stock[name];
            }
            return 0;
        }
    }
}
