using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // () => expression
            // x => expression
            // (x,y)=> expression
            //var factor = 5;
            //Func<int, int> squareFn = x => x * x * factor;
            //var result = squareFn(5);
            //Console.WriteLine(result);
            var anonymousObject = new { Name = "John", Location = "Paris" };
            Console.WriteLine(anonymousObject.Name);
            var bookRepository = new BookRepository();
            var books = bookRepository.GetBooks();
            var booksCheaperThan30 = books.FindAll(x=> x.Price < 30);

            foreach (var book in booksCheaperThan30)
            {
                Console.WriteLine(book.Title);
            }
        }

        static bool CheaperThan30(Book book)
        {
            return book.Price < 30;
        }
        static int Square(int number)
        {
            return number * number;
        }
    }
}
