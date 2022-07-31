using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Project1
{
    internal class main
    {
        static void Main(string[] args)
        {

            //GetByCategory categorys = new GetByCategory();
            //categorys.showFirst();

            int menu = 0;
            int category = 0;
            while (true)
            {
               menu= Input.numbers(("what do you want to do?"
                  + "\n1.All Product"
                  + "\n2.Get By Category" +
                     "\n2.5.Back to previous menu"
                  + "\n3.Basket" 
                  + "\n4.Order"));
                Menu.showMenu(menu);
                if (menu == 2)
                {
                    while (true)
                    {
                        category = Input.numbers("choose one type");
                        Menu.showCategory(category);
                        if (category == 5)
                        {
                            break;
                        }
                    }
                    

                }else if(menu == 3)
                {

                }

            }

            
          
            
           
          


        }
       
        }



    }

