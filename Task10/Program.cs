Console.WriteLine("Напишите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа --> {secondDigit}");
}
else
{
    Console.WriteLine("Число не является трехзначным");
}
int SecondDigit (int num)
{
    return ((num / 10) % 10);
}
