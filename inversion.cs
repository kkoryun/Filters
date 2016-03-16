using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
   class Inversion : Filters
    {
        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {
            Color sourceColor = sourceMap.GetPixel(x, y);
            Color resultColor = Color.FromArgb(255 - sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);
            return resultColor;
            throw new NotImplementedException();
        }
    }
}
