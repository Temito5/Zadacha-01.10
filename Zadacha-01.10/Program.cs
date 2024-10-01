using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_01._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kvadrat a1 = new Kvadrat(double.Parse(Console.ReadLine()));
            a1.PandS();
            a1.Print();
        }
    }
}
