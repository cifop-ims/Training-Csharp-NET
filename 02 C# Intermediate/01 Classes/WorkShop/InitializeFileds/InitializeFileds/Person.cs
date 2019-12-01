using System;
using System.Collections.Generic;

namespace InitializeFileds
{
    public class Person
    {
        public readonly List<Order> orders = new List<Order>();
        public readonly DateTime CreatedOn = DateTime.Now;
        public Person()
        {

        }
    }
}
