// Программа, которая принимает на вход координаты точки  X Y,
// и выдаёт номер четверти в которой находится эта точка,
// причём X Y не равны нулю

Console.WriteLine("Enter coordinate X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate Y");
int y = Convert.ToInt32(Console.ReadLine());
switch ((x, y))
{
    case ( > 0, > 0):
        Console.WriteLine("The point is in the first quarter");
        break;
    case ( < 0, > 0):
        Console.WriteLine("The point is in the second quarter");
        break;
    case ( < 0, < 0):
        Console.WriteLine("The point is in the third quarter");
        break;
    case ( > 0, < 0):
        Console.WriteLine("The point is in the fourth quarter");
        break;
}

