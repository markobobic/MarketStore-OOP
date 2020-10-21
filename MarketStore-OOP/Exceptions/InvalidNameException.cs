using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Exceptions
{
	public class InvalidNameException : Exception
	{

		public InvalidNameException(string message, Exception cause) : base(message, cause)
		{
		}

		public InvalidNameException(string message) : base(message)
		{
		}
	}
}
