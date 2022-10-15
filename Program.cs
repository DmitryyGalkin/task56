/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей
 суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт
 номер строки с наименьшей суммой элементов: 1 строка 
 (нумерация строк начинается с 1) */
Console.Clear();

Console.WriteLine("Введите значение m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение n:");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
SumRowsArray(array);
PrintSumRow(SumRowsArray(array));


void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }

}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 10);
        }
    }
}

int[] SumRowsArray(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {

            sum += array[i, j];

        }
        sumRow[i] = sum;
    }
    return sumRow;
}
void PrintSumRow(int[] array)
{
    int minSumElemets = array[0];
    int row = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSumElemets)
        {
            minSumElemets = array[i];
            row = i + 1;
        }

    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов:{row}");
}