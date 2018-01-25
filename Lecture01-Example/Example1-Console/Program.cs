using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入名字:");
            string name = Console.ReadLine();
            Console.Write("今天心情如何?");
            string status = Console.ReadLine();
            Console.WriteLine("我叫{0},今天心情{1}", name, status);
        }
    }
}