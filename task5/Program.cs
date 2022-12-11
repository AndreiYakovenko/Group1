Console.WriteLine("Please enter three-digit number");
int N = Convert.ToInt32(Console.ReadLine());
if ((1000>N) && (N>99))
{
    Console.WriteLine("The last number " + N%10);
}
else
{
    Console.WriteLine("Error, please enter three-digit number!!!");
}