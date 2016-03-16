using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class Shift : Filters
    {
        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {

            int positionX = x + 100;
            int positionY = y;
            Color c;
            if (positionX < 0 || positionX >= sourceMap.Width)
            {
                c = Color.FromArgb(255, 0, 255);
            }
            else
                c = sourceMap.GetPixel(positionX, positionY);

            return c;
            throw new NotImplementedException();
        }
    }
}
