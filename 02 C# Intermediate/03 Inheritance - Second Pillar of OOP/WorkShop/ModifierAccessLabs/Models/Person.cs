using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        protected string Name { get; set; }

        protected internal string Age { get; }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
