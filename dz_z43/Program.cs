Console.WriteLine("Введите число b1");
if (!double.TryParse(Console.ReadLine()!, out double b1))
{
    Console.WriteLine("Введено не число");
    return;
}

Console.WriteLine("Введите число k1");
if (!double.TryParse(Console.ReadLine()!, out double k1))
{
    Console.WriteLine("Введено не число");
    return;
}

Console.WriteLine("Введите число b2");
if (!double.TryParse(Console.ReadLine()!, out double b2))
{
    Console.WriteLine("Введено не число");
    return;
}

Console.WriteLine("Введите число k1");
if (!double.TryParse(Console.ReadLine()!, out double k2))
{
    Console.WriteLine("Введено не число");
    return;
}


double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;


if (k1 == k2)
{
    Console.WriteLine("Точек пересечения не существует");
    return;
}

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");