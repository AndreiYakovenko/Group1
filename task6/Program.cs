Random random = new Random();
int number = random.Next(10, 100);
Console.WriteLine("Random number = {0}", number);
int a = number / 10;
int b = number % 10;
if (a>b)
Console.WriteLine("a>b, {0}", a);
else if(b>a)
Console.WriteLine("b>a, {0}", b);
else
Console.WriteLine("a==b, {0}", a);