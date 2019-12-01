using System;

namespace ConstructorLab
{
    public class Customer
    {
        public int Id;
        public string Name;
        public DateTime CreatedOn;
        public Customer()
        {
            this.CreatedOn = DateTime.Now;
        }
        public Customer(string name):this()
        {
            this.Name = name;
        }

        public Customer(int id, string name) : this(name)
        {
            this.Id = id;
        }
    }
}
