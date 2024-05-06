using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int numRows = myMatrix.GetLength(0);
        int numColums = myMatrix.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int k = 0; k < numColums; k++)
            myMatrix[i, k] *= myMatrix[i, k];
        }
        return myMatrix;
    }
}
