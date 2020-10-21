using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Exceptions
{
	public class InvalidTurnoverException : Exception
	{

		public InvalidTurnoverException(string message, Exception cause) : base(message, cause)
		{
		}

		public InvalidTurnoverException(string message) : base(message)
		{
		}
	}
}
