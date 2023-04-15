Console.WriteLine("Введите первое число") ;
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число") ;
int number2 = Convert.ToInt32(Console.ReadLine());
int remainder = Remainder (number1, number2);
if (remainder == 0)
{
    Console.WriteLine("Кратно") ;   
} 
else
{
    Console.WriteLine(remainder);
}
int Remainder (int num1, int num2)
{
    return num1 % number2;
}

