using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    class GrayScaleFilter : Filters
    {
        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {
            Color sourceColor = sourceMap.GetPixel(x, y);
            float a = 0.36f , b = 0.56f , c=0.11f;
            int intensity =(int)(a * sourceColor.R + b* sourceColor.G + c* sourceColor.B);
            intensity = clamp(intensity, 0, 255);
            Color resultColor = Color.FromArgb(intensity, intensity, intensity);
            return resultColor;
            throw new NotImplementedException();
        }
    }
}
