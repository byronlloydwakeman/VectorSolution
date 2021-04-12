using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    public class Vector
    {
        List<int> DataValues = new List<int>();
        public int Dimension { get; }

        public Vector(int x, int y)
        {
            Dimension = 2;
            DataValues.Add(x);
            DataValues.Add(y);
        }

        public Vector(int x, int y, int z)
        {
            Dimension = 3;
            DataValues.Add(x);
            DataValues.Add(y);
            DataValues.Add(z);
        }

        private void IsIndexInRange(int axis)
        {
            if (axis > Dimension)
            {
                throw new ArgumentException("Invalid dimension argument");
            }
            if(axis < 1)
            {
                throw new ArgumentException("Dimension parameter cannot be less than 1");
            }
        }

        public void EditVector(int axis, int newValue)
        {
            //Make sure the index is within range
            IsIndexInRange(axis);

            //Change value at given index
            DataValues[axis - 1] = newValue;
        }


        public double Magnitude()
        {
            double returnSum = 0;
            foreach (var element in DataValues)
            {
                returnSum += Math.Pow(Convert.ToDouble(element), 2.0);
            }

            return Math.Pow(returnSum, 0.5);
        }


        private static void AreVectorsOfSameDimension(int d1, int d2)
        {
            if (d1 != d2)
            {
                throw new ArgumentException("Dimension of given vectors aren't equal");
            }
        }

        public static int DotProduct(Vector v1, Vector v2)
        {
            //Make sure dot product can be performed
            AreVectorsOfSameDimension(v1.Dimension, v2.Dimension);

            int tempSum = 0;
            for (int i = 0; i < v1.DataValues.Count; i++)
            {
                tempSum += v1.DataValues[i] * v2.DataValues[i];
            }

            return tempSum;
        }

        /// <summary>
        /// Returns the angle between two vectors in radians
        /// </summary>
        public static double FindAngleBetweenVectors(Vector v1, Vector v2)
        {
            return Math.Acos(DotProduct(v1, v2) / (v1.Magnitude() * v2.Magnitude()));
        }

        public override string ToString()
        {
            string returnString = "";

            if (Dimension == 2)
            {
                returnString = $"({DataValues[0]}i + {DataValues[1]}j)";
            }
            else
            {
                returnString = $"({DataValues[0]}i + {DataValues[1]}j + {DataValues[2]}k)";
            }

            return returnString;
        }

        public static Vector operator *(Vector v1, Vector v2)
        {
            //Check vectors are same dimension
            AreVectorsOfSameDimension(v1.Dimension, v2.Dimension);

            //Vector to return
            Vector vectorToReturn;

            //If 2D
            if (v1.Dimension == 2)
            {
                vectorToReturn = new Vector((v1.DataValues[0] * v2.DataValues[1]), -(v1.DataValues[1] * v2.DataValues[0]));
            }
            else //If 3D
            {
                vectorToReturn = new Vector((v1.DataValues[1] * v2.DataValues[2] - v1.DataValues[2] * v2.DataValues[1]),
                    (v1.DataValues[2] * v2.DataValues[0] - v1.DataValues[0] * v2.DataValues[2]), (v1.DataValues[0] * v2.DataValues[1] - v1.DataValues[1] * v2.DataValues[0]));
            }

            return vectorToReturn;
        }
    }
}
