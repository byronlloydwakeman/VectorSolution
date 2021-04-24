using System;
using VectorLibrary;
using VectorMathLibrary;

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

            //IPlane somePlane = new ScalarPlane(new Vector(4, 4, -7), 13);
            //IPlane someOtherPlane = new ScalarPlane(new Vector(7, -4, 4), 6);

            //Console.WriteLine(Angle.FindAngleBetweenPlanes(somePlane, someOtherPlane));

            ILine line1 = new VectorLine(new Vector(0, 0, 0), new Vector(2, 3, 0));
            ILine line2 = new VectorLine(new Vector(0, 0, 0), new Vector(3, -6, 3));

            Console.WriteLine($"Angle betweenn lines {line1} and {line2} is {Angle.FindAngleBetweenLines(line1, line2)}rad or {Angle.FindAngleBetweenLines(line1, line2) * (180/Math.PI)} degrees");

            Console.ReadKey();
        }
    }
}
