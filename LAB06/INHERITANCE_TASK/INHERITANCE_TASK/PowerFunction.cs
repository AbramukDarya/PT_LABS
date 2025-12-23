using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE_TASK
{
    using System;

    namespace OOP_INHERITANCE
    {
        public class PowerFunction : Function
        {
            private double a, n;

            public PowerFunction(double lower, double upper, double coef, double power)
                : base(lower, upper, $"Power({coef}*x^{power})")
            {
                a = coef;
                n = power;
            }

            public override double GetValue(double x)
            {
                CheckBounds(x);
                return a * Math.Pow(x, n);
            }
        }

    }
}   
