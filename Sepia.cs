using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    class Sepia : Filters
    {

        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {
            Color sourceColor = sourceMap.GetPixel(x, y);
            float a = 0.36f, b = 0.56f, c = 0.11f;
            int intensity = (int)(a * sourceColor.R + b * sourceColor.G + c * sourceColor.B);
            int k = 2;
            float r = intensity + 2 * k, g = intensity + 0.5f * k; b  = intensity - 1 * k;
            r = clamp((int)r, 0, 255);
            g = clamp((int)g, 0, 255);
            b = clamp((int)b, 0, 255);
            Color resultColor = Color.FromArgb((int)r, (int)g, (int)b);
            return resultColor;
            throw new NotImplementedException();
        }
    }
}
