Console.WriteLine("Введите цифру дня недели");
int day = Convert.ToInt32 (Console.ReadLine());
if (ValidateDate(day))
{
    if (IsWeekend(day))
    {
        Console.WriteLine("Это выходной") ;
    }
    else
    {
        Console.WriteLine("Это не выходной");
    }
}

bool ValidateDate (int d)
{
    if (d > 0 && d <=7)
    {
        return true;       
    }
    Console.WriteLine("Это не день недели");
    return false;
} 

bool IsWeekend (int d)
{
    if (d > 5)
    {
        return true;
    }
    return false;
}