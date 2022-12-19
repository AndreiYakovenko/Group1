// Нахождение факториала

int Fact(int num)
{
    Console.WriteLine(num);
    if (num==1) return 1;
    return num * Fact(num-1);
}
Console.WriteLine(Fact(6));