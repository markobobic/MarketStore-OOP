using MarketStore_OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP.BusinessLogic
{
  public sealed  class CashDesk
    {
		private const double ONE_HUNDRED = 100;
		private const string PURCHASE_VALUE = "Purchase value: ";
		private const string DISCOUNT_RATE = "Discount rate: ";
		private const string PURCHASE_DISCOUNT = "Discount: ";
		private const string TOTAL_AMOUNT = "Total: ";
		private const string BUYER_OWNER = "Customer: ";

		private CashDesk()
        {

        }

		public static string Pay(ICart ShoppingCart,IDiscountCard Card)
        {
			double cardDiscountRate = Card.DiscountRate;
			double purchaseValue = ShoppingCart.PurchaseValue;

			double purchaseDiscount = CalculatePurchaseDiscount(purchaseValue, cardDiscountRate);
			double totalAmount = CalculateTotalAmount(purchaseValue, purchaseDiscount);
			string owner = Card.CardHolder.FulName;

			StringBuilder InvoiceBuilder = new StringBuilder();

			InvoiceBuilder.Append(string.Concat(PURCHASE_VALUE, purchaseValue.ToString("C"))).Append(Environment.NewLine)
				.Append(string.Concat(DISCOUNT_RATE, cardDiscountRate.ToString() + '%'))
				.Append(Environment.NewLine)
				.Append(string.Concat(PURCHASE_DISCOUNT, purchaseDiscount.ToString("C")))
				.Append(Environment.NewLine)
				.Append(string.Concat(TOTAL_AMOUNT, totalAmount.ToString("C")))
				.Append(Environment.NewLine)
				.Append(string.Concat(BUYER_OWNER, owner));
				
			return InvoiceBuilder.ToString();
		}

		private static double CalculatePurchaseDiscount(double purchaseValue, double cardDiscountRate)
		{
			return purchaseValue * cardDiscountRate / ONE_HUNDRED;
		}

		private static double CalculateTotalAmount(double purchaseValue, double discount)
		{
			return purchaseValue - discount;
		}
	}
}
