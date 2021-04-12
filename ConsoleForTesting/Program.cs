using System;
using VectorLibrary;
using VectorMath;

namespace ConsoleForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vector vector1 = new Vector(1, 2);
            //Vector vector2 = new Vector(2, 5);

            //Console.WriteLine($"Dot product of {vector1} and {vector2} is {Vector.DotProduct(vector1, vector2)}");

            //Console.WriteLine(vector1.Magnitude());

            //Console.WriteLine(Vector.FindAngleBetweenVectors(vector1, vector2));

            IPlane somePlane = new ScalarPlane(new Vector(4, 4, -7), 13);
            IPlane someOtherPlane = new ScalarPlane(new Vector(7, -4, 4), 6);

            Console.WriteLine(Angle.FindAngleBetweenPlanes(somePlane, someOtherPlane));

            Console.ReadKey();
        }
    }
}
