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
        }

        static List<T> GetInitializedList<T>(T value, int count)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < count; i++)
            {
                list.Add(value);
            }
            return list;
        }
    }
}
