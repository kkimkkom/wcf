using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginReference.LoginClient client = new LoginReference.LoginClient();
            Console.Write("Enter email: ");
            string user = Console.ReadLine();
            Console.Write("Enter password: ");
            string pass = Console.ReadLine();

            string res = client.Login(user, pass);
            Console.WriteLine(res);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
