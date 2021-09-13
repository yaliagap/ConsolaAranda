using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aranda.ASDK.External;

namespace ConsolaAranda
{
    class Program
    {
        static void Main(string[] args)
        {
            Token token = new Token();

            string token_string = token.Get(0);

            Console.WriteLine("Token: ");
            Console.WriteLine(token_string);
            Console.ReadLine();
        }
    }
}
