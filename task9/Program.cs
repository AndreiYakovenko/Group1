Console.WriteLine("Please enter number");
int a = Convert.ToInt32(Console.ReadLine());
int b = a%23;
int c = a%7;
if (b==0 && c==0) Console.WriteLine("YES!");
else Console.WriteLine("NO!");