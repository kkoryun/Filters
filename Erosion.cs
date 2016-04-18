using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Filters
{
    class Erosion : Filters
    {
        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {
            int radiusX = 2;
            int radiusY = 2;

            Color[] arr = new Color[25];
            int i = 0;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = clamp(x + k, 0, sourceMap.Width  - 1);
                    int idY = clamp(y + l, 0, sourceMap.Height - 1);
                    arr[i] = sourceMap.GetPixel(idX, idY);
                    i++;
                }
         
            IComparer com = new ColorComparer();
            Array.Sort(arr, com);
            return arr[0];
        }
    }
}
