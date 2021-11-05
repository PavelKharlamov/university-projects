using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OC_Lab2
{
    class KrBrush : Brush
    {
        public KrBrush(Color brushColor, int size)
            : base(brushColor, size)
        {
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            try
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {

                    for (int y0 = y - Size; y0 < y + Size; ++y0)
                    {
                        image.SetPixel(x, y0, BrushColor);
                    }
                }
            }
            
            catch { }
        }
    }
}