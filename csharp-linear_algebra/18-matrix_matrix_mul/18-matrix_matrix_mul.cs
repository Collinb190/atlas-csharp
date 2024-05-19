using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int col1 = matrix1.GetLength(1);
        int col2 = matrix2.GetLength(1);
        int row1 = matrix1.GetLength(0);
        int row2 = matrix2.GetLength(0);
        double[,] fail = new double[,] { {-1} };
        double[,] product = new double[row1, col2];

        if (col1 != row2)
            return fail;
        for (int i = 0; i < row1; i++)
            for (int j = 0; j < col2; j++)
                for (int k = 0; k < col1; k++)
                {
                    product[i, j] += matrix1[i, k] * matrix2[k, j];
                }
        return product;
    }
}