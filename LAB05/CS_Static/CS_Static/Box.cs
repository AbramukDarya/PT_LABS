using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Static
{
        public class Box
        {
            private double length;
            private double width;
            private double depth;

            public double Length
            {
                get { return length; }
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("Length must be > 0");
                    length = value;
                }
            }

            public double Width
            {
                get { return width; }
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("Width must be > 0");
                    width = value;
                }
            }

            public double Depth
            {
                get { return depth; }
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("Depth must be > 0");
                    depth = value;
                }
            }

            public Box(double length, double width, double depth)
            {
                Length = length;
                Width = width;
                Depth = depth;
            }

            public static Box operator +(Box b1, Box b2)
            {
                double newLength = Math.Max(b1.Length, b2.Length);
                double newWidth = Math.Max(b1.Width, b2.Width);
                double newDepth = Math.Max(b1.Depth, b2.Depth);

                return new Box(newLength, newWidth, newDepth);
            }

            public static Box operator -(Box bigger, Box smaller)
            {
                if (bigger.Length < smaller.Length || bigger.Width < smaller.Width || bigger.Depth < smaller.Depth)
                {
                var temp = bigger;
                bigger = smaller;
                smaller = temp;
                }

                if (bigger.Length < smaller.Length || bigger.Width < smaller.Width || bigger.Depth < smaller.Depth)
                throw new InvalidOperationException("Меньшая коробка не помещается в большую");

                double freeLength = bigger.Length - smaller.Length;
                double freeWidth = bigger.Width - smaller.Width;
                double freeDepth = bigger.Depth - smaller.Depth;

                return new Box(freeLength, freeWidth, freeDepth);
            }


        public double Volume()
            {
                return Length * Width * Depth;
            }

            public override bool Equals(object? obj)
            {
                if (obj is Box other)
                return this.Volume() == other.Volume();
                return false;
            }

          
            public override string ToString()
            {
                return $"Box [{Length}, {Width}, {Depth}]";
            }

          
            public override int GetHashCode()
            {
                return Volume().GetHashCode();
            }
        }
}
