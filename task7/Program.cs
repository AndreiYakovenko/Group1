Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine("Random number = {0}", number);
int number1 = number/100;
int number2 = number/10%10;
int number3 = number%10;
Console.WriteLine(number1*10+number3);