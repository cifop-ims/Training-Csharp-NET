using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4 };
            list.Add(1);
            list.AddRange(new int[3] { 5, 6, 7 });
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count :" + list.Count);

            Console.WriteLine("index of 1 :" + list.IndexOf(1));
            Console.WriteLine("last index of 1 :" + list.LastIndexOf(1));

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 1)
                    list.Remove(list[i]);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
