int number = new Random().Next(10, 100);
Console.WriteLine ($"Случайное число --> {number}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}"); 

int maxDigit = MaxDigit (number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}"); 

int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}