using MarketStore_OOP.BusinessLogic;
using MarketStore_OOP.Interfaces;
using MarketStore_OOP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //bronze card
            ICart bronzeShopCart = new StoreCart();
            IItem remote = new Item("LG", 150);
            CardHolder cardHolderBronze = new CardHolder("Anthony", "Hopkins");
            bronzeShopCart.AddItem(remote);
            IDiscountCard bronzeCard = new BronzeCard(0,cardHolderBronze);
            string billBronze = CashDesk.Pay(bronzeShopCart, bronzeCard);
            Console.WriteLine(billBronze+Environment.NewLine);
            //silver card
            ICart silverShopCart = new StoreCart();
            IItem playStation = new Item("PlayStation 5", 850);
            silverShopCart.AddItem(playStation);
            CardHolder cardHolderSilver = new CardHolder("Jake", "Gyllenhaal");
            IDiscountCard silverCard = new SilverCard(600,cardHolderSilver);
            string billSilver = CashDesk.Pay(silverShopCart, silverCard);
            Console.WriteLine(billSilver + Environment.NewLine);
            //gold car
            ICart goldShopCart = new StoreCart();
            goldShopCart.AddItem(new Item("Toy", 300));
            goldShopCart.AddItem(new Item("Cooker", 700));
            goldShopCart.AddItem(new Item("Pack-man", 300));
            CardHolder cardHolderGold = new CardHolder("Christian", "Bale");
            IDiscountCard goldenCard = new GoldCard(1300,cardHolderGold);
            string billGold = CashDesk.Pay(goldShopCart, goldenCard);
            Console.WriteLine(billGold + Environment.NewLine);
            Console.ReadLine();
            
        }
    }
}
