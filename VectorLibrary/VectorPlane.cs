using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    public class VectorPlane : IPlane
    {
        public Vector PositionVector { get; set; }
        public Vector DirectionVector1 { get; set; }
        public Vector DirectionVector2 { get; set; }
        private int Scalar1 { get; set; }
        private int Scalar2 { get; set; }

        public VectorPlane(Vector PositionVector, Vector DirectionVector1, Vector DirectionVector2)
        {
            this.PositionVector = PositionVector;
            this.DirectionVector1 = DirectionVector1;
            this.DirectionVector2 = DirectionVector2;
        }

        public Vector ReturnNormalVector()
        {
            throw new NotImplementedException();
            //return DirectionVector1 * DirectionVector2;
        }
    }
}
