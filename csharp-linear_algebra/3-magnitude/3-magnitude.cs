using System;

namespace _3_magnitude
{
    class VectorMath
    {
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
            return Math.Round(result, 2);
        }
    }
}
