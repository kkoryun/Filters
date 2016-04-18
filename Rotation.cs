using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class Rotation: Filters
    {
        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {
            int positionX =(int) ((x - sourceMap.Width / 2) * Math.Cos(1.5708) - (y-sourceMap.Height/2)*Math.Sin(1.5708)+ sourceMap.Width / 2);
            int positionY = (int)((x - sourceMap.Width / 2) * Math.Sin(1.5708) + (y - sourceMap.Height / 2) * Math.Cos(1.5708) + sourceMap.Height / 2);
            if (positionX < sourceMap.Width && positionX > 0 && positionY < sourceMap.Height && positionY > 0)
            {
                Color c = sourceMap.GetPixel(positionX, positionY);
                return c;
            }
            else
            {
                Color c = Color.FromArgb(255, 255, 255);
                return c;
            }
            throw new NotImplementedException();
        }
    }
}
