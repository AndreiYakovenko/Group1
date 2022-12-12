Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine($"Random number = {number}");
Console.WriteLine("Please enter number position to delete");
int delete = Convert.ToInt32(Console.ReadLine());
var str = number.ToString();
number = int.Parse(str.Remove(str.Length - delete, 1));
Console.WriteLine(number);
// считает цифры для удаления справа