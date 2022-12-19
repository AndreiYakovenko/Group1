// Нахождение факториала

// int Fact(int num)
// {
//     Console.WriteLine(num);
//     if (num==1) return 1;
//     return num * Fact(num-1);
// }
// Console.WriteLine(Fact(6));

// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Please enter number");
int N = Convert.ToInt32(Console.ReadLine());

string Row(int N)
{
    if (N == 1) return "1";
    return Row(N-1) + " " + N;
}   
Console.WriteLine(Row(N));