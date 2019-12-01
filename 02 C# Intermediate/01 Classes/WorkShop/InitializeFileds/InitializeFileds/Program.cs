using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializeFileds
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.orders.Add(
                new Order
                {
                    Date = DateTime.Now,
                    ProductName = "Phone",
                    Id = 1001
                });
        }
    }
}
