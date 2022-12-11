Console.WriteLine("Input number 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int b = Convert.ToInt32(Console.ReadLine());
if (b*b == a)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}