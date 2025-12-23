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
        public class TrigonometricFunction : Function
        {
            private string type;

            public TrigonometricFunction(double lower, double upper, string trigType)
                : base(lower, upper, $"Trig({trigType})")
            {
                type = trigType.ToLower();
            }

            public override double GetValue(double x)
            {
                CheckBounds(x);

                return type switch
                {
                    "sin" => Math.Sin(x),
                    "cos" => Math.Cos(x),
                    "tan" => Math.Tan(x),
                    _ => throw new ArgumentException($"Неизвестный тип тригонометрической функции: {type}")
                };
            }
        }
    }

}

