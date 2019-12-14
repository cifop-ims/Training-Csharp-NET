using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultLabs
{
    public enum PersonType : byte
    {
        Person,
        Customer
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person { Name = "John" };
            //var customer = new Customer { Name = "Bill", InscriptionDate = new System.DateTime(2019, 1, 1) };
            //DisplayName(customer);

            var person = CreatePerson(PersonType.Person);
            System.Console.WriteLine(person.Name);
            if (person is Customer)
            {
                Customer customer = (Customer)person;
                System.Console.WriteLine(customer.InscriptionDate);
            }
        }
        static Person CreatePerson(PersonType personType)
        {
            if (personType == PersonType.Customer)
            {
                return new Customer { Name = "Bill", InscriptionDate = new System.DateTime(2019, 1, 1) };
            }
            return new Person { Name = "John" };
        }
        static void DisplayName(Person person)
        {
            System.Console.WriteLine(person.Name);
        }
    }
}
