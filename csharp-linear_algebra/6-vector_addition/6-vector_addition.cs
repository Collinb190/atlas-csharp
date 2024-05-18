using System;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] vectorSum = new double[vector1.Length];
        double[] vectorSumFail = new double[1] { -1 };

        if (vector1.Length != vector2.Length) 
            return vectorSumFail;
        if (vector1.Length != 2 && vector1.Length !=3)
            return vectorSumFail;
        for (int i = 0; i < vector1.Length; i++)
        {
            vectorSum[i] = vector1[i] + vector2[i];
        }
        return vectorSum;
    }
}
