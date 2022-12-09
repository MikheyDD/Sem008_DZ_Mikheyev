// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = FillMatrix(2, 2);
int[,] matrix2 = FillMatrix(2, 2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrix3 = MultiplyMatix(matrix1, matrix2);
PrintMatrix(matrix3);


int[,] MultiplyMatix(int[,] matr1, int[,] matr2)
{
    int rows = matr1.GetLength(0);
    int columns = matr2.GetLength(1);
    int[,] matr3 = new int[rows, columns];
    if (matr1.GetLength(0) == matr2.GetLength(1))
    {
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr1.GetLength(1); j++)
            {
                matr3[i, j] = 0;
                for (int k = 0; k < matr1.GetLength(1); k++)
                {
                    matr3[i, j] += matr1[i, k] * matr2[k, j];
                }
            }



        }

    }
    return matr3;
}





int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}