int number = new Random().Next();
Console.WriteLine ($"Случайное число --> {number}");
if (number > 99 && number < 1000)
{
    int thirdDigit = ThreeDigit (number);
    Console.WriteLine($"Третье число --> {thirdDigit}");
}
else
{
    if (number >= 1000)
    {
        int thirdDigit = MultipleDigit (number);
        Console.WriteLine($"Третье число --> {thirdDigit}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
int ThreeDigit(int num)
{
    return (number % 10);
}
int MultipleDigit (int num)
{
    int interDigit = number;
    while (interDigit > 999)
        interDigit = interDigit / 10;
    return (interDigit % 10);
}