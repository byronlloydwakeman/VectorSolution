using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    public interface ILine
    {
        public Vector ReturnDirectionVector();
        public Vector ReturnPositionVector();

    }
}
