// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите нужное колличество строк: ");
int arrNum = Convert.ToInt32(Console.ReadLine());
int[,] spiral = ArrayMatrix(arrNum);
PrintMatrix(spiral);
int[,] ArrayMatrix(int arr)
{
    int[,] spiralMatrix = new int[arr, arr];
    int step = 1;
    int layer = 0;
    while (layer < arr / 2)
    {
        for (int i = 0 + layer; i < spiralMatrix.GetLength(0) - layer; i++)
        {
            spiralMatrix[layer, i] = step;
            step++;
        }
        for (int j = 1 + layer; j < spiralMatrix.GetLength(1) - layer; j++)
        {
            spiralMatrix[j, arr - 1 - layer] = step;
            step++;
        }
        for (int k = spiralMatrix.GetLength(1) - 2 - layer; k >= layer; k = k - 1)
        {
            spiralMatrix[spiralMatrix.GetLength(1) - 1 - layer, k] = step;
            step++;
        }
        for (int l = spiralMatrix.GetLength(1) - 2 - layer; l >= layer + 1; l = l - 1)
        {
            spiralMatrix[l, layer] = step;
            step++;
        }
        layer++;
    }
    if (arr % 2 == 1) spiralMatrix[arr / 2, arr / 2] = step;
    return spiralMatrix;
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