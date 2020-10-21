using MarketStore_OOP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Interfaces
{
  public interface IDiscountCard
    {
        double PreviousMonthTurnover { get; }

        double DiscountRate { get; }

        CardHolder CardHolder { get; }
    }
}
