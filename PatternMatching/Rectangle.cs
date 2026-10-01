using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
        public class Rectangle
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                if (width <= 0 || height <= 0)
                {
                    throw new ArgumentException(
                        "Ширина и высота должны быть больше нуля."
                    );
                }

                Width = width;
                Height = height;
            }

            public override string ToString()
            {
                return $"Rectangle {{ Width = {Width}, Height = {Height} }}";
            }
        }
    
}
