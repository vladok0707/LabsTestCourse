using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class TriangleAccept
    {
        public static bool  Check(float x, float y, float z)
        {
            if (x > 0 && y > 0 && z > 0)
            {
                return (x + y > z && x + z > y && y + z > x);

            }
            return false;
        }
    }
}
