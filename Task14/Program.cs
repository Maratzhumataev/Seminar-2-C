Console.WriteLine("Введите число") ;
int number = Convert.ToInt32(Console.ReadLine());

bool result = Result(number);
Console.WriteLine(result ? "да" : "нет");
bool Result (int num)
{
    return num % 7==0 && num % 23==0;
}