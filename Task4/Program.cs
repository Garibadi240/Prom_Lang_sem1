
Console.WriteLine("Введите число a: ");
int userNumber1 = int.Parse(Console.ReadLine()??"");

Console.WriteLine("Введите число b: ");
int userNumber2 = int.Parse(Console.ReadLine()??"");

Console.WriteLine("Введите число c: ");
int userNumber3 = int.Parse(Console.ReadLine()??"");



if(userNumber1==userNumber2 && userNumber1==userNumber3)
{
    Console.WriteLine($"Все числа равны И максимальное число равно: {userNumber1}");
} else 
{
    if (userNumber1>userNumber2)
    {
        if (userNumber1>userNumber3)
        {
            Console.WriteLine($"MAX число a: {userNumber1}");
        }
    }
    if (userNumber2>userNumber1)
    {
        if (userNumber2>userNumber3)
        {
            Console.WriteLine($"MAX число b: {userNumber2}");
        }
    }
    if (userNumber3>userNumber1)
    {
        if (userNumber3>userNumber2)
        {
            Console.WriteLine($"MAX число c: {userNumber3}");
        }
    }
}