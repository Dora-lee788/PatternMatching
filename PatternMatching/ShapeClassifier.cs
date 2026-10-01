using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    public static class ShapeClassifier
    {
        public static string Classify(object shape)
        {
            return shape switch
            {
                Circle { Radius: 0 } => "точка",

                Circle { Radius: > 100 } => "огромный круг",

                Circle => "обычный круг",

                Rectangle rectangle when rectangle.Width == rectangle.Height
                    => "квадрат",

                Rectangle => "обычный прямоугольник",

                _ => "неизвестная фигура"
            };
        }
    }
}
