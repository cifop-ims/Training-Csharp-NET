using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLabs
{
    class Program
    {
        static void Main()
        {
            Test<int> test1 = new Test<int>(5);
            test1.Write();

            Test<string> test2 = new Test<string>("cat");
            test2.Write();


            Test<Employee> test3 = new Test<Employee>(new Employee());

            var list = GetInitializedList<string>("cat", 5);
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }

        static ICollection<T> GetInitializedList<T>(T value, int count)
        {
            ICollection<T> list = new List<T>();
            AddItems(value, count, list);
            return list;
        }

        private static void AddItems<T>(T value, int count, ICollection<T> list)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(value);
            }
        }
    }
}
