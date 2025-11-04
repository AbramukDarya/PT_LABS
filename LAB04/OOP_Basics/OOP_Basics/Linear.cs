using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    public class Linear
    {

        public double A { get; set; }
        public double B { get; set; }

        public Linear(double a, double b)
        {
            this.A = a; 
            this.B = b;
        }

        public double Calculate(double x)
        {
            return A * x + B;
        }

        public void PrintEquation()
        {
            System.Console.WriteLine($"y = {A}x + {B}");
        }
    }
}