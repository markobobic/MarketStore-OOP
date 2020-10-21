using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Interfaces
{
 public interface IItem
    {
        string Name { get; }

        double Price { get; }
    }
}
