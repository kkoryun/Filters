using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class Wave: Filters
    {
        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {

            int positionX = clamp((int)(x + 20 * Math.Sin(2 * Math.PI * y / 60)), 0, sourceMap.Width-1);
            int positionY = clamp(y, 0, sourceMap.Height-1);
            Color c = sourceMap.GetPixel(positionX, positionY);
            return c;
            throw new NotImplementedException();
        }
        
    }
}
