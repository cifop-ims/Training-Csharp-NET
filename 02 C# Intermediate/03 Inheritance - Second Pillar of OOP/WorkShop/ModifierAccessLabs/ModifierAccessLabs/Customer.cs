using Models;
using System;

namespace ModifierAccessLabs
{
    class Customer : Person
    {
        public DateTime InscriptionDate { get; set; }

        public void GetName()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
        }
    }

}
