using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    abstract class MoveFilter
    {
        protected abstract int positionX(int _x, int _y);
        protected abstract int positionY(int _x, int _y);

        public Bitmap processImage(Bitmap sourceMap)
        {
            Bitmap resultMap = new Bitmap(sourceMap.Width+100, sourceMap.Height+100);
             for (int i = 0; i < sourceMap.Height; i++)
            {
                //worker.ReportProgress((int)((float)i / resultMap.Width * 100));

                for (int j = 0; j < sourceMap.Width; j++)
                {
                    resultMap.SetPixel(positionX(j, i), positionY(j, i), sourceMap.GetPixel(j, i));
                }
            }
            return resultMap;
        }
    }
}
