using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace Filters
{
    public class ColorComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            int intensityX = (int) (((Color)x).R * 0.36 + ((Color)x).G * 0.53 + ((Color)x).B * 0.11);
            int intensityY = (int) (((Color)y).R * 0.36 + ((Color)y).G * 0.53 + ((Color)y).B * 0.11);
            if (intensityX > intensityY)
                return 1;
            if (intensityX < intensityY)
                return -1;

            return 0;

        }
    }
}
