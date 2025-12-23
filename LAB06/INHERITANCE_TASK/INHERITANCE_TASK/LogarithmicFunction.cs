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
        public class LogarithmicFunction : Function
        {
            private double a;

            public LogarithmicFunction(double lower, double upper, double coeff)
                : base(lower, upper, $"Log({coeff}*ln(x))")
            {
                a = coeff;
            }

            public override double GetValue(double x)
            {
                CheckBounds(x);
                if (x <= 0)
                    throw new ArgumentException("Логарифм определён только для x > 0");
                return a * Math.Log(x);
            }
        }
    }
}
