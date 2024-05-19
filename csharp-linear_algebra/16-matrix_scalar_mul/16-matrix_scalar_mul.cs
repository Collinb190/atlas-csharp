using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int row1 = matrix.GetLength(0);
        int col1 = matrix.GetLength(1);

        double[,] fail = new double[,] { {-1} };
        double[,] scaled = new double[row1, col1];

        if (row1 != 2 && row1 != 3)
            return fail;
        for (int i = 0; i < row1; i++)
            for (int j = 0; j < col1; j++)
            {
                scaled[i, j] = matrix[i, j] * scalar;
            }
        return scaled;
    }
}