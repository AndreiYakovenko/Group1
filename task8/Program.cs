Console.WriteLine("Please number 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter number 2");
int b = Convert.ToInt32(Console.ReadLine());
if (a%b==0) Console.WriteLine("a multiple of b");
else Console.WriteLine("not a multiple of b, remainder = " + a%b);