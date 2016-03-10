using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    public interface IWarehouse
    {
        void add(string name, int count);

        void remove(string name, int count);

        bool hasInventory(string name, int count);

        int getInventory(string name);
    }
}
