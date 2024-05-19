using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] vectorProduct = new double[vector.Length];
        double[] vectorProductFail = new double[1] { -1 };

        if (vector.Length != 2 && vector.Length !=3)
            return vectorProductFail;
        for (int i = 0; i < vector.Length; i++)
        {
            vectorProduct[i] = vector[i] * scalar;
        }
        return vectorProduct;
    }
}
