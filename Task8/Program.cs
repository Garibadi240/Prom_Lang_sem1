Console.WriteLine("Введите число: ");
int userNumber = int.Parse(Console.ReadLine() ?? "");

int i = 2;
if (userNumber % 2 == 0)
{
    while (i < userNumber - 2)
    {
        Console.Write($"{i}, ");
        i = i + 2;
    }
    i = i + 2;
    Console.Write($"{i}.");
}
else
{
    while (i < userNumber-2)
    {
        Console.Write($"{i}, ");
        i = i + 2;
    }
    Console.Write($"{i}.");
}
