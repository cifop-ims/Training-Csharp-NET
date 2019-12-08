using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpCookies = new HttpCookies();
            httpCookies.Fill();
            //httpCookies.SetCookie("username", "ahedfi000");
            httpCookies["username"] = "ahedfi001";
            //Console.WriteLine(httpCookies.GetCookie("username"));
            Console.WriteLine(httpCookies["username"]);
        }
    }
}
