using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    static class Input
    {
        public static String text(String item)
        {
            Console.WriteLine(item);
            String answer = Console.ReadLine();
            return answer;

        }
       
       public static int numbers(String title)
        {
            Console.WriteLine(title);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
    }

}