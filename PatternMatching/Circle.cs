using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
        public class Circle
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                if (radius < 0)
                {
                    throw new ArgumentException(
                        "Радиус не может быть отрицательным."
                    );
                }

                Radius = radius;
            }

            public override string ToString()
            {
                return $"Circle {{ Radius = {Radius} }}";
            }
        }
    
}
