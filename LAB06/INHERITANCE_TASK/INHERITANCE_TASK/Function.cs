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
        public abstract class Function
        {
            public double LowerBound { get; protected set; }
            public double UpperBound { get; protected set; }
            public string FunctionName { get; protected set; }

            protected Function(double lower, double upper, string name)
            {
                if (lower > upper)
                {
                    LowerBound = upper;
                    UpperBound = lower;
                }
                else
                {
                    LowerBound = lower;
                    UpperBound = upper;
                }
                FunctionName = name;
            }

            protected void CheckBounds(double x)
            {
                if (x < LowerBound || x > UpperBound)
                    throw new ArgumentOutOfRangeException(
                        nameof(x),
                         $"x = {x} находится вне допустимого диапазона [{LowerBound}, {UpperBound}]"
                       );
            }

            public abstract double GetValue(double x);

            public override string ToString()
            {
                var output = new StringBuilder();
                output.Append($"{FunctionName}(x)[{LowerBound}, {UpperBound}] = ");

                int start = (int)Math.Ceiling(LowerBound);
                int end = (int)Math.Floor(UpperBound);

                for (int x = start; x <= end; x++)
                {
                    try
                    {
                        double val = GetValue(x);
                        output.AppendLine($"\nf({x}) = {Math.Round(val, 4)}");
                    }

                    catch (Exception ex)
                    {
                        output.AppendLine($"\nf({x}) = недоступно ({ex.Message})");
                    }
                }

                return output.ToString().Trim();
            }
        }
    }
}