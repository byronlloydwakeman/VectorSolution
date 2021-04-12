using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    public class ScalarPlane : IPlane
    {
        public Vector NormalVector { get; set; }
        public Vector GeneralVector { get; set; }
        public int Scalar { get; set; }

        public ScalarPlane(Vector NormalVector, int Scalar)
        {
            this.NormalVector = NormalVector;
            this.Scalar = Scalar;
        }

        public Vector ReturnNormalVector()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"r . {NormalVector}";
        }
    }
}
