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
        public class LinearFunction : Function
        {
            private double a, b;

            public LinearFunction(double lower, double upper, double a, double b)
                : base(lower, upper, $"Linear({a}x + {b})")
            {
                this.a = a;
                this.b = b;
            }

            public override double GetValue(double x)
            {
                CheckBounds(x);
                return a * x + b;
            }
        }
    }
}
