using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    public class CartesianLine : ILine
    {
        public Vector DirectionVector { get; set; }
        public Vector PositionVector { get; set; }
        private int X { get; set; }
        private int Y { get; set; }
        private int Z { get; set; }

        public CartesianLine(Vector DirectionVector, Vector PositionVector)
        {
            this.DirectionVector = DirectionVector;
            this.PositionVector = PositionVector;
        }

        public Vector ReturnDirectionVector()
        {
            return DirectionVector;
        }

        public Vector ReturnPositionVector()
        {
            return PositionVector;
        }
    }
}
