using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    class VectorLine : ILine
    {
        public Vector PositionVector { get; set; }
        public Vector DirectionVector { get; set; }
        private int Scalar { get; set; }

        public Vector ReturnDirectionVector()
        {
            throw new NotImplementedException();
        }

        public Vector ReturnPositionVector()
        {
            throw new NotImplementedException();
        }
    }
}
