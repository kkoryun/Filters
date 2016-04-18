﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public    MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }

        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;
            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = clamp(x + k, 0, sourceMap.Width - 1);
                    int idY = clamp(y + l, 0, sourceMap.Height - 1);
                    Color neighborColor = sourceMap.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }
            
            return Color.FromArgb(clamp((int)resultR, 0, 255), clamp((int)resultG, 0, 255), clamp((int)resultB, 0, 255));


        }
    }
}
