using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class GetByCategory 
    {
     
        
        public static void showCategory()
        { 

            List<String> products = new List<String>();
            products.Add("1:Laptops");
            products.Add("2:Phones");
            products.Add("3:Tv");
            products.Add("4:HeadPhones");
            foreach(var product in products)
            {
                Console.WriteLine(product);
            }
          
           
          

        }
        public  static void  showFirst()
        {
            List<String> products = new List<String>();
            products.Add("1:Samsung");
            products.Add("2:Dell");
            products.Add("3:Asus");
            products.Add("4:Acer");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
        public static void showSecond()
        {
            List<String> products = new List<String>();
            products.Add("1:Samsung ");
            products.Add("2:Iphone");
            products.Add("3:Alcatel ");
            products.Add("4:Xiomi ");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
        public  static void showThird()
        {
            List<String> products = new List<String>();
            products.Add("1:Samsung");
            products.Add("2:Sony");
            products.Add("3:LG");
            products.Add("4:Artel");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
        public  static void showFourth()
        {
            List<String> products = new List<String>();
            products.Add("1:Samsung");
            products.Add("2:Iphone");
            products.Add("3:Xiomi");
            products.Add("4:Sony");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

    }
}
