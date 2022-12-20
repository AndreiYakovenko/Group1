// Программа, которая по заданному номеру четверти,
// показывает диапазон возможных координат
// точек X Y в этой четверти

Console.WriteLine("Enter quarter number");
int n = Convert.ToInt32(Console.ReadLine());
switch (n)
{
    case 1:
        Console.WriteLine("Range of possible coordinates - x = 0+ y = 0+");
        break;
    case 2:
        Console.WriteLine("Range of possible coordinates - x = 0- y = 0+");
        break;
    case 3:
        Console.WriteLine("TRange of possible coordinates - x = 0- y = 0-");
        break;
    case 4:
        Console.WriteLine("Range of possible coordinates - x = 0+ y = 0-");
        break;
    default:
        Console.WriteLine("Non-existent quarter number, please enter a number between 1 and 4");
        break;
}