using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    public interface IOrder
    {
        int Count { get; set; }
        string Name { get; set; }
        bool isFilled { get; set; }

        void fill(Warehouse warehouse);
    }
}
