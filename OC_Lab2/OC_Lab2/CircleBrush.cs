using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OC_Lab2
{
    class CircleBrush : Brush
    {
        public CircleBrush(Color brushColor, int size)
            : base(brushColor, size)
        {
        }

        public override void Draw(Bitmap image, int x0, int y0)
        {
            try
            {
                for (int y = y0 - Size; y < y0 + Size; ++y)
                {
                    int x = (int)Math.Sqrt(Size * Size - (y - y0) * (y - y0)) + x0;
                    image.SetPixel(x, y, BrushColor);
                    int x2 = -(int)Math.Sqrt(Size * Size - (y - y0) * (y - y0)) + x0;
                    image.SetPixel(x2, y, BrushColor);
                }
                for (int x = x0 - Size; x < x0 + Size; ++x)
                {
                    int y = (int)Math.Sqrt(Size * Size - (x - x0) * (x - x0)) + y0;
                    image.SetPixel(x, y, BrushColor);
                    int y2 = -(int)Math.Sqrt(Size * Size - (x - x0) * (x - x0)) + y0;
                    image.SetPixel(x, y2, BrushColor);
                }
            }
            
            catch { }
        }
    }
}
