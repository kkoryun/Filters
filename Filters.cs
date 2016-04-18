using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
   abstract class Filters
    {
        protected abstract Color сonvertPixel(Bitmap sourceMap, int x, int y);
        public Bitmap proccesImage(Bitmap sourceMap, BackgroundWorker worker)
        {
            Bitmap resultMap = new Bitmap(sourceMap.Width, sourceMap.Height);

            for (int i = 0; i < sourceMap.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultMap.Width * 100));
                if (worker.CancellationPending)
                    return sourceMap;
                 
                for (int j = 0; j < sourceMap.Height; j++)
                    resultMap.SetPixel(i, j, сonvertPixel(sourceMap, i, j));
            }
            return resultMap;
        } 
        public int clamp(int tmp, int min , int max)
        {
            if (tmp > max) return max;
            if (tmp < min) return min;
            return tmp;
        }

    }

}
