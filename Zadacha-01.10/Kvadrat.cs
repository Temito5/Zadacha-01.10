using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_01._10
{
    public class Kvadrat
    {
        private double a;
        private double p;
        private double s;
        public double A
        {
            get { return a; }
            set
            { a = value; }
        }

        public Kvadrat(double a)
        {
            this.a = a;
        }

        public void PandS()
        {
               p = 4 * a;
               s = a * a;
        }

        public void Print()
        {
            Console.WriteLine($"P={p} S={s}");
        }
    }
}
