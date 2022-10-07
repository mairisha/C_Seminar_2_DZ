// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите чило");
int daynumber=Convert.ToInt32(Console.ReadLine());
if (daynumber==7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    if (daynumber==6)
    {
        Console.WriteLine("Суббота");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}