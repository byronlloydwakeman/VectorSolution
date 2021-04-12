using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorLibrary;

namespace VectorMath
{
    public static class Angle
    {
        public static double FindAngleBetweenLines(ILine line1, ILine line2)
        {
            return Vector.FindAngleBetweenVectors(line1.ReturnDirectionVector(), line2.ReturnDirectionVector());
        }

        public static double FindAngleBetweenPlanes(IPlane plane1, IPlane plane2)
        {
            return Vector.FindAngleBetweenVectors(plane1.ReturnNormalVector(), plane2.ReturnNormalVector());
        }
    }
}
