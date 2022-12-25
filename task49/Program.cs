// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти
// элементы на их квадраты.

Console.WriteLine("Please enter the number of lines:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

void FillArray(int m, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
}

FillArray(m, n);
PrintArray(array);
Console.WriteLine();
for (int i = 2; i<array.GetLength(0); i+=2)
{
    for (int j = 2; j<array.GetLength(1); j+=2)
    {
        array[i,j]=array[i,j]*array[i,j];
    }
}
PrintArray(array);