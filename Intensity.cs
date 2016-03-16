using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    class Intensity : Filters
    {
        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {
            Color sourceColor = sourceMap.GetPixel(x, y);
            int R = sourceColor.R, G = sourceColor.G, B = sourceColor.B;
            R = clamp(R + 100, 0, 255); G = clamp(G + 100, 0, 255); B = clamp(B + 100, 0, 255);
            Color resultColor = Color.FromArgb(R,G,B);
            return resultColor;
        }
    }
}
