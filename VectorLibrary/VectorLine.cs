using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    public class VectorLine : ILine
    {
        public Vector PositionVector { get; set; }
        public Vector DirectionVector { get; set; }
        private int Scalar { get; set; }

        public VectorLine(Vector PositionVector, Vector DirectionVector)
        {
            this.PositionVector = PositionVector;
            this.DirectionVector = DirectionVector;
        }

        public Vector ReturnDirectionVector()
        {
            return DirectionVector;
        }

        public Vector ReturnPositionVector()
        {
            return PositionVector;
        }

        public override string ToString()
        {
            return $"r = {PositionVector} + λ{DirectionVector}";
        }
    }
}
