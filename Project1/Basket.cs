using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Basket
    {
          public static int item=0;
       public static void orders()
        {
            
            List<int>  order = new List<int>();
            order.Add(0);   
            order.Add(1);
            order.Add(2);
            order.Add(3);
            int count = order.ToArray().Length;
            if (item != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    order.Remove(i);
                   
                }
                
            }
            Console.WriteLine( "Order's count:"+order.Count);

           
           
        }
    }
}
