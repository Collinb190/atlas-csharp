using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if the input matrix has more than two columns
        if (matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };
        
        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        double[,] result = new double[matrix.GetLength(0), 2];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result[i, 0] = Math.Round(matrix[i, 0] * cos - matrix[i, 1] * sin, 2);
            result[i, 1] = Math.Round(matrix[i, 0] * sin + matrix[i, 1] * cos, 2);
        }

        return result;
    }
}