// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array2D = ArrayMR(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
ArrayInRow(array2D);
PrintMatrix(array2D);


int[] Numarr(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j + 1] > array[j])
            {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

void ArrayInRow(int[,] matrix)

{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] arrayRow = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arrayRow[j] = matrix[i, j];
        }
        Numarr(arrayRow);
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i, k] = arrayRow[k];
        }
    }
}

int[,] ArrayMR(int rows, int columns, int min, int max)
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