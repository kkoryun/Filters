using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class MotionBlur:MatrixFilter
    {
        public MotionBlur()
        {
            
            kernel = new float [3,3]  { {1,0,0 } , {0,1,0 },{0,0,1 } };
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    kernel[i, j] /= 3;
        }
    }
}
