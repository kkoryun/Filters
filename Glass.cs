using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class Glass: Filters
    {
        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {
            Random rand = new Random();
            int positionX = (int)(x + (rand.Next(1) - 0.5) * 10);
            int positionY = (int)(y + (rand.Next(1) - 0.5) * 10);
            positionX = clamp(positionX, 0, sourceMap.Width);
            positionY = clamp(positionY, 0, sourceMap.Height);
            Color c = sourceMap.GetPixel(positionX, positionY);
            return c;
            throw new NotImplementedException();
        }
        
    }
}
