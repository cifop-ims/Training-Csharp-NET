using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 0;
            var customerType = 1; //permium
            //if(customerType == 1)
            //{
            //    price = 15;
            //}
            //else
            //{
            //    price = 25;
            //}
            switch (customerType)
            {
                case 0://gold
                case 1://silver
                    price = 15;
                    break;
                case 2://bronze
                    price = 20;
                    break;
                default:
                    price = 25;
                    break; 
            }

            price = (customerType == 1) ? 15 : 25;
        }
    }
}
