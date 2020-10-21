using MarketStore_OOP.Exceptions;
using MarketStore_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Model
{
  public class Item : IItem
    {
        private const double MIN_PRICE = 0;
        private const string ERROR_MSG_NAME_EMPTY = "Item name cannot be empty";
        private const string ERROR_MSG_PRICE_NEGATIVE = "Item price must be greater than 0.";

        private string name;
        private double price;

        public string Name
        {
            set
            {
                if (string.ReferenceEquals(value, null) || value.Length == 0)
                {
                    throw new InvalidNameException(ERROR_MSG_NAME_EMPTY);
                }
                name = value;
            }
            get
            {
                return name;
            }
        }

        public double Price
        {
            set
            {
                if (value < MIN_PRICE)
                {
                    throw new InvalidPriceException(ERROR_MSG_PRICE_NEGATIVE);
                }
                price = value;
            }
            get
            {
                return price;
            }
        }

        public Item(string name,double price)
        {
            Name = name;
            Price = price;
        }
    }
}
