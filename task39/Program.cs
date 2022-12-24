// Переворот массива

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int help = 0;
for (int i = 0; i < arr.Length / 2; i++)
{
    help = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = help;
}
Console.WriteLine(String.Join(" ", arr));