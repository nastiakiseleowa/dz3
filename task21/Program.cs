while (true)
{
    Console.WriteLine("Введите координаты точки А: ");
    Console.Write("X = ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y = ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Z = ");
    double z1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите координаты точки B: ");
    Console.Write("X = ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Y = ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Z = ");
    double z2 = Convert.ToDouble(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

    Console.WriteLine(result);
}