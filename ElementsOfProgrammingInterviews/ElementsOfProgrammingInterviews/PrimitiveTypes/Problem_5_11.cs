using System;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.PrimitiveTypes
{
    public class Problem_5_11
    {
        public Rectangle Solution(Rectangle a, Rectangle b)
        {
            if (IsIntersects(a, b))
            {
                var x = Math.Max(a.X, b.X);
                var y = Math.Max(a.Y, b.Y);

                return new Rectangle(x, y,
                    Math.Min(a.X + a.Width, b.X + b.Width) - x,
                    Math.Min(a.Y + a.Height, b.Y + b.Height) - y);
            }

            return new Rectangle(0, 0, -1, -1);
        }

        private bool IsIntersects(Rectangle a, Rectangle b)
        {
            return a.X <= b.X + b.Width && a.X + a.Width >= b.X &&
                   a.Y <= b.Y + b.Height && a.Y + a.Height >= b.Y;
        }
    }
}