using System;
using System.Collections.Generic;

namespace Project1
{
     class AllProduct
    {
        public AllProduct()
        {

        }
        public  static  void showProduct()
        {
            
            List<String> products = new List<String>();
            products.Add("1:Electronics");
            products.Add("2:Clothes");
           
            
            foreach(String product in products)
            {
                Console.WriteLine(product);
            }
        }
        
    }
}
