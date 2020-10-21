using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Exceptions
{
	public class InvalidPriceException : Exception
	{

		public InvalidPriceException(string message, Exception cause) : base(message, cause)
		{
		}

		public InvalidPriceException(string message) : base(message)
		{
		}
	}
}
