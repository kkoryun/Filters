using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters 
{
    class Sobel : Filters
    {
        protected float[,] kernel = null;

        protected override Color сonvertPixel(Bitmap sourceMap, int x, int y)
        {
            kernel = new float[3, 3] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;


            float resultRX = 0;
            float resultGX = 0;
            float resultBX = 0;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = clamp(x + k, 0, sourceMap.Width - 1);
                    int idY = clamp(y + l, 0, sourceMap.Height - 1);
                    Color neighborColor = sourceMap.GetPixel(idX, idY);
                    resultRX += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultGX += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultBX += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }

            kernel = new float[3, 3] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            float resultRY = 0;
            float resultGY = 0;
            float resultBY = 0;
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = clamp(x + k, 0, sourceMap.Width - 1);
                    int idY = clamp(y + l, 0, sourceMap.Height - 1);
                    Color neighborColor = sourceMap.GetPixel(idX, idY);
                    resultRY += neighborColor.R * kernel[k + radiusX, l + radiusY];
                    resultGY += neighborColor.G * kernel[k + radiusX, l + radiusY];
                    resultBY += neighborColor.B * kernel[k + radiusX, l + radiusY];
                }

            return Color.FromArgb(
                                  clamp((int)Math.Sqrt(resultRX * resultRX + resultRY * resultRY), 0, 255),
                                  clamp((int)Math.Sqrt(resultGX * resultGX + resultGY * resultGY), 0, 255),
                                  clamp((int)Math.Sqrt(resultBX * resultBX + resultBY * resultBY), 0, 255)
                                  );
            //return Color.FromArgb(
            //                      clamp((int)Math.Abs(resultRX  + resultRY), 0, 255), 
            //                      clamp((int)Math.Abs(resultGX + resultGY ), 0, 255), 
            //                      clamp((int)Math.Abs(resultBX  + resultBY), 0, 255)
            //                      );

            //return Color.FromArgb(
            //                      clamp((int)resultRY, 0, 255),
            //                      clamp((int)resultGY, 0, 255),
            //                      clamp((int)resultBY, 0, 255)
            //                      );
        }
    }
}
