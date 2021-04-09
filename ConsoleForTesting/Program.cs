using System;
using VectorLibrary;

namespace ConsoleForTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(1, 2);
            Vector vector2 = new Vector(2, 5);

            Console.WriteLine($"Dot product of {vector1} and {vector2} is {Vector.DotProduct(vector1, vector2)}");

            Console.WriteLine(vector1.Magnitude());

            Console.WriteLine(Vector.FindAngleBetweenVectors(vector1, vector2));

            Vector vector3 = new Vector(1, 2, 3);
            Vector vector4 = new Vector(1, 5, 8);

            Console.WriteLine((vector3 * vector4).ToString());

            Console.ReadKey();
        }
    }
}
