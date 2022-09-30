Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int lastdg = number % 10;
    Console.WriteLine($"Последняя цифра трехзначного числа - {lastdg}");
}
else
{
Console.WriteLine("Число не трехзначное!");
}