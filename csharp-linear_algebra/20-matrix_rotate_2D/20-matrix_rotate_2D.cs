using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Check if the input matrix has more than two columns
        if (matrix.GetLength(1) > 2)
            return new double[,] { { -1 } };
        
        // Define the 2D rotation matrix
        double[,] rotationMatrix = {
            { Math.Cos(angle), -Math.Sin(angle) },
            { Math.Sin(angle), Math.Cos(angle) }
        };
        
        double[,] transformedPoint = new double[2, 2];

        // Perform matrix multiplication to rotate each point
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    transformedPoint[i, j] += Math.Round(matrix[i, k] * rotationMatrix[k, j], 2);
        return transformedPoint;
    }
}