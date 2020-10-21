using MarketStore_OOP.Exceptions;
using MarketStore_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Model
{
    public abstract class BaseCard : IDiscountCard
    {
        private const double MIN_TURNOVER = 0;
        private const string ERROR_MSG_TURNEOVER_NEGATIVE_VALUE = "Turnover value must be greater than 0.";
        private double previousMonthTurnover;
        public abstract CardHolder CardHolder { get; }
        public abstract double DiscountRate { get; }
     
        private double Turnover
        {
            set
            {
                if (value < MIN_TURNOVER)
                {
                    throw new InvalidTurnoverException(ERROR_MSG_TURNEOVER_NEGATIVE_VALUE);
                }
                previousMonthTurnover = value;
            }
        }
        public virtual double PreviousMonthTurnover
        {
            get
            {
                return previousMonthTurnover;
            }
        }

        protected internal BaseCard(double turnover,CardHolder cardHolder)
        {
           Turnover = turnover;
        }
    }
}
