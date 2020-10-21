using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Model
{
   public sealed class BronzeCard : BaseCard
    {
        private const double ONE_PERCENT = 1;
        private const double TWO_AND_HALF_PERCENT = 2.5;
        private const double INITIAL_DISCOUNT = 0;
        private const double THREE_HUNDRED_DOLLARS = 300;
        private const double ONE_HUNDERED_DOLLARS = 100;
        
        public override double DiscountRate
        {
            get
            {
                return base.PreviousMonthTurnover < ONE_HUNDERED_DOLLARS ? INITIAL_DISCOUNT : base.PreviousMonthTurnover <= THREE_HUNDRED_DOLLARS ? ONE_PERCENT : TWO_AND_HALF_PERCENT;
            }
        }

        public override CardHolder CardHolder { get; }

        public BronzeCard(double turnover,CardHolder cardHolder) : base(turnover,cardHolder)
        {
            CardHolder = cardHolder == null? throw new NullReferenceException() : cardHolder;
        }

    }
}
