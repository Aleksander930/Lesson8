// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array = MatrixArray(2, 2, 1, 5);
PrintMatrix(array);
Console.WriteLine();
int[,] numMatrix = MatrixArray(2, 3, 1, 5);
PrintMatrix(numMatrix);
Console.WriteLine();
if (ArrMatrixnum(array, numMatrix))
{
    int[,] matrixMultiplyResult = Matrix(array, numMatrix);
    Console.WriteLine("Ответ:");
    PrintMatrix(matrixMultiplyResult);
}
else Console.WriteLine("Не корректные значения");
int[,] Matrix(int[,] matrixA, int[,] matrixB)
{
    int[,] ResultMatrixNum = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    int numberMatrix = matrixA.GetLength(1);
    for (int i = 0; i < ResultMatrixNum.GetLength(0); i++)
    {
        for (int j = 0; j < ResultMatrixNum.GetLength(1); j++)
        {
            for (int k = 0; k < numberMatrix; k++)
            {
                ResultMatrixNum[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return ResultMatrixNum;
}
bool ArrMatrixnum(int[,] matrixA, int[,] matrixB)
{
    return matrixA.GetLength(1) == matrixB.GetLength(0);
}
int[,] MatrixArray(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }

        Console.WriteLine("|");
    }
}