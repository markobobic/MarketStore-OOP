using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Model
{
  public sealed class SilverCard : BaseCard
    {
        private const double INITIAL_DISCOUNT = 2;
        private const double THREE_AND_HALF_PERCENT = 3.5;
        private const double THREE_HUNDRED_DOLLARS = 300;
        public override double DiscountRate
        {
            get
            {
                return base.PreviousMonthTurnover <= THREE_HUNDRED_DOLLARS ? INITIAL_DISCOUNT : THREE_AND_HALF_PERCENT;
            }
        }

        public override CardHolder CardHolder { get; }

        public SilverCard(double turnover, CardHolder cardHolder) : base(turnover, cardHolder)
        {
            CardHolder = cardHolder == null ? throw new NullReferenceException() : cardHolder;
        }

        
    }
}
