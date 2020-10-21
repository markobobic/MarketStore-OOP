using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.Exceptions
{
	public class InvalidItemsCollectionException : Exception
	{

		public InvalidItemsCollectionException(string message, Exception cause) : base(message, cause)
		{
		}

		public InvalidItemsCollectionException(string message) : base(message)
		{
		}
	}
}
