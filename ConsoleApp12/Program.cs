using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetMarket
{
    abstract class Delivery
    {
        public string Address;
    }
    class HomeDelivery : Delivery
    {
        
    }
    class PickPointDelivery : Delivery
    {
        
    }
    class ShopDelivery : Delivery
    {
        
    }
    class Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
