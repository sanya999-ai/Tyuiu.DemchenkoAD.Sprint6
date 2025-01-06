﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DemchenkoAD.Sprint6.Task3.V8.Lib
{
    public class DataService : ISprint6Task3V8
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[3, j] % 2 == 0)
                    {
                        matrix[3, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
