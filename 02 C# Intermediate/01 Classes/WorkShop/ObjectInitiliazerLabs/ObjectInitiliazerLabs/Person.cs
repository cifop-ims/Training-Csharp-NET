using System;

namespace ObjectInitiliazerLabs
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;

        public Person(string createdBy)
        {
            Console.WriteLine($"{createdBy} create a new instance of Person");
        }
    }
}
