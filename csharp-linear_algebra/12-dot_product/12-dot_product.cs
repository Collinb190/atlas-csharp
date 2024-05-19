using System;

class VectorMath
{
   public static double DotProduct(double[] vector1, double[] vector2)
    {
        double vectorDotProduct = 0.0;
        double vectorDotProductFail = -1.0;

        if (vector1.Length != vector2.Length) 
            return vectorDotProductFail;
        if (vector1.Length != 2 && vector1.Length !=3)
            return vectorDotProductFail;
        for (int i = 0; i < vector1.Length; i++)
        {
            vectorDotProduct += vector1[i] * vector2[i];
        }
        return vectorDotProduct;
    }
}
