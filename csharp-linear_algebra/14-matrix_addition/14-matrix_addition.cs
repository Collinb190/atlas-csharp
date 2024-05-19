using System;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int row1 = matrix1.GetLength(0);
        int col1 = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);
        int col2 = matrix2.GetLength(1);
        double[,] fail = new double[,] { {-1} };
        double[,] sum = new double[row1, col1];

        if (row1 != row2 || col1 != col2)
            return fail;
        if (row1 != 2 && row1 != 3)
            return fail;
        for (int i = 0; i < row1; i++)
            for (int j = 0; j < col1; j++)
            {
                sum[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        return sum;
    }
}
