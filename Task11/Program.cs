int number = new Random().Next(100, 1000);
Console.WriteLine ($"Случайное число --> {number}");

int deleteCenter = DeleteCenter (number);
int DeleteCenter (int num)
{
    int first = num / 100;
    int third = num % 10;
    int answer = first * 10 + third;
    return answer;
}
Console.WriteLine($"Двузначное число {deleteCenter}");
