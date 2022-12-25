// Задайте двумерный массив m на nб каждый элемент в массиве,
// каждый элемент находится по формуле Amn = m + n

Console.WriteLine("Please enter the number of lines:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
        Console.Write($"{array[i, j]}" + " ");
    }
    Console.WriteLine();
}