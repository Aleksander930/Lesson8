// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array2D = Array(2, 2, 2, 10, 99);
PrintArray(array2D);
bool InArr(int[] array, int num)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            result = true;
            break;
        }
    }
    return result;
}
int[,,] Array(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    int[] arrMatrix = new int[rows * columns * depth];
    int countArr = 0;
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
                while (InArr(arrMatrix, matrix[i, j, k]))
                {
                    matrix[i, j, k] = rnd.Next(min, max + 1);
                }
                arrMatrix[countArr] = matrix[i, j, k];
                countArr++;
            }

        }
    }
    return matrix;
}
void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],4} ({i}, {j}, {k})");
            }
        }
        Console.WriteLine();
    }
}