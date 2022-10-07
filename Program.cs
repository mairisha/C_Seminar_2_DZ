/// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Задайте первое число");
int numberA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второе число");
int numberB=Convert.ToInt32(Console.ReadLine());
if (numberA==numberB*numberB)
{
    Console.WriteLine("Первое число являеться квадратом второго");
}
else
{
    Console.WriteLine("Первое число не являеться квадратом второго");
}