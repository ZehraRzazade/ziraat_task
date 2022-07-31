using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    static class Menu
    {
        public static void showMenu(int number)
        { 
            switch (number)
            {
                case 1: 
                    AllProduct.showProduct();
                    break;
                    case 2:  GetByCategory.showCategory();
                    break;
                case 3: Basket.orders();
                    break;
                case 4: Order.removeProducts();
                    break;
                default:
                    Console.WriteLine("select one number please");
                    break;
            }
        }
        public static void showCategory(int number)
        {
            switch (number)
            {
                case 1:
                    GetByCategory.showFirst();
                    break;
                case 2:
                    GetByCategory.showSecond();
                    break;
                case 3:
                    GetByCategory.showThird();
                    break;
                case 4:
                    GetByCategory.showFourth();
                    break;
                default:
                    Console.WriteLine("select one number please");
                    break;
            }

        }
    }
}
