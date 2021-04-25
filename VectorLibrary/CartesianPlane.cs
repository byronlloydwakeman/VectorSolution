using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    public class CartesianPlane : IPlane
    {
        public Vector NormalVector { get; set; }
        private int X { get; set; }
        private int Y { get; set; }
        private int Z { get; set; }

        public CartesianPlane(Vector NormalVector)
        {
            this.NormalVector = NormalVector;
        }

        public Vector ReturnNormalVector()
        {
            return NormalVector;
        }

        public override string ToString()
        {
            return $"({NormalVector.ReturnDataValues()[0]}x + {NormalVector.ReturnDataValues()[1]}y + {NormalVector.ReturnDataValues()[2]}z)";
        }
    }
}
