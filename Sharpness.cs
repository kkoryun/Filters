using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Filters
{
    class Sharpness : MatrixFilter
    {
        public Sharpness()
        {

            kernel = new float[3, 3] { { 0, -1, 0 }, { -1, 4, -1 }, { 0, -1, 0 } };
        }
    }
}
