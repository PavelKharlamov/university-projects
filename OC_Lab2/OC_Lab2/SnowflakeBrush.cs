using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace OC_Lab2
{
    class SnowflakeBrush : Brush
    {
        public SnowflakeBrush(Color brushColor, int size)
            : base(brushColor, size)
        {
        }


        public override void Draw(Bitmap image, int x, int y)
        {
            try
            {
                for (int i = -Size; i < +Size; ++i)
                {
                    image.SetPixel(x - i, y + i, BrushColor);
                    image.SetPixel(x - i, y - i, BrushColor);
                }

                for (int y0 = y - Size; y0 < y + Size; ++y0)
                {
                    image.SetPixel(x, y0, BrushColor);
                }

                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    image.SetPixel(x0, y, BrushColor);
                }
            }
            
            catch { }
        }
    }
}
