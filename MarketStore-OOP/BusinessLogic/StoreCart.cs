using MarketStore_OOP.Exceptions;
using MarketStore_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.BusinessLogic
{
 
    public class StoreCart : ICart
    {
        private const string ERROR_ITEMS_LIST = "Item's list is invalid";
        private IList<IItem> items;

		private IList<IItem> Items
        {
            set
            {
                if(value==null || value.Count == 0)
                {
                    throw new InvalidItemsCollectionException(ERROR_ITEMS_LIST);
                }
                items = value;
            }
        }
        public virtual double PurchaseValue
        {
            get
            {
                return items.Sum(x => x.Price);
            }
        }

        public StoreCart()
        {
            items = new List<IItem>();
        }

        public StoreCart (IList<IItem> items)
        {
            Items = items;
        }

        public virtual void AddItem(IItem item)
        {
            items.Add(item);
        }
	}


}
