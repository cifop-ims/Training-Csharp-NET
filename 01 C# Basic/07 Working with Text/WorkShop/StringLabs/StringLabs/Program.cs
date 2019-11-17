using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(null);
            string fullName = "Ahmed Hedfi ";
            Console.WriteLine("Trim : '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper : '{0}'", fullName.Trim().ToUpper());
            int index = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, index);
            string lastName = fullName.Substring(index + 1);
            Console.WriteLine("firstName : '{0}'", firstName);
            Console.WriteLine("lastName : '{0}'", lastName);
            Console.WriteLine(fullName.Replace("ahmed", "hello"));
            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");
            string str = "100";
            decimal ammount = Convert.ToDecimal(str);
            ammount.ToString("C");
        }
    }
}
