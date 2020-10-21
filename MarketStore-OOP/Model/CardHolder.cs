using MarketStore_OOP.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Model
{
   public class CardHolder
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private const string ERROR_MSG_FIRST_NAME_EMPTY = "Cardholder first name cannot be empty";
        private const string ERROR_MSG_LAST_NAME_EMPTY = "Cardholder last name cannot be empty";
        public string FulName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        protected CardHolder(CardHolder cardHolder)
        {
            FirstName = cardHolder.FirstName;
            LastName = cardHolder.LastName;
        }

        public CardHolder(string firstName,string lastName)
        {
            FirstName = firstName == null || firstName.Length == 0 ?
                throw new InvalidNameException(ERROR_MSG_FIRST_NAME_EMPTY) : firstName;
            LastName = lastName ==null || lastName.Length == 0 ?
                throw new InvalidNameException(ERROR_MSG_LAST_NAME_EMPTY) : lastName;
        }
        
    }
}
