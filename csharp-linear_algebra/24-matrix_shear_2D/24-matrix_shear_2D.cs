using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(1) != 2 || (direction != 'x' && direction != 'y'))
            return new double[,] { {-1} };

        double xScale = 0, yScale = 0;
        double[,] result = new double[matrix.GetLength(0), 2];

        if (direction == 'x') xScale = factor;
        else yScale = factor;

        // X' = x + s * y
        // Y' = y + s * x
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result[i, 0] = matrix[i, 0] + (xScale * matrix[i, 1]);
            result[i, 1] = matrix[i, 1] + (yScale * matrix[i, 0]);
        }
        return result;
    }
}
