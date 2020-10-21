using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Model
{
 public sealed class GoldCard:BaseCard
    {
        private const double MAX_DISCOUNT = 10;
        private const double INITIAL_DISCOUNT = 2;
        private const double ONE_HUNDERED_DOLLARS = 100;
        private const double DISCOUNT_RATE_INCREMENT = 1;
        public override double DiscountRate
        {
            get
            {
                double discount = INITIAL_DISCOUNT;
                discount += (base.PreviousMonthTurnover / ONE_HUNDERED_DOLLARS) * DISCOUNT_RATE_INCREMENT;
                return discount > MAX_DISCOUNT ? MAX_DISCOUNT : discount;
            }
        }

        public override CardHolder CardHolder { get; }

        public GoldCard(double turnover, CardHolder cardHolder) : base(turnover, cardHolder)
        {
            CardHolder = cardHolder == null ? throw new NullReferenceException() : cardHolder;
        }

        
    }
}
