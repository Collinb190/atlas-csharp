using System;

namespace _3_magnitude
{
    class VectorMath
    {
        static void Main(string[] args)
        {
            double answer = Magnitude(new double[] {3.0, 4.0} );
            Console.WriteLine(answer);
        }

        public static double Magnitude(double[] vector)
        {
            double result = 0;
            double squaredResult = 0;

            if (vector.Length != 2 && vector.Length != 3)
                return -1;

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = Math.Abs(vector[i]);
                squaredResult += vector[i] * vector[i];
            }
            
            result = Math.Sqrt(squaredResult);
            return result;
        }
    }
}
