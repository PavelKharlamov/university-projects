using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OC_Lab2
{
    class LasticBrush : Brush
    {
     
            public LasticBrush(Color LasticColor, int size)
                : base(LasticColor, size)
            {
            }



            public override void Draw(Bitmap image, int x, int y)
            {
                try
                {
                for (int y0 = y - Size; y0 < y + Size; ++y0)


                    for (int x0 = x - Size; x0 < x + Size; ++x0)
                    {
                        image.SetPixel(x0, y0, BrushColor);
                    }
                }
                
                catch { }
            }
        
    }
}
