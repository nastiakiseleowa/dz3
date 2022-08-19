while (true)
{
    Console.Write("Введите пятизначное число: ");
    string Number = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
    if (Number[0] == Number[4] & Number[1] == Number[3])
    Console.WriteLine("палиндром");
    else Console.WriteLine("не палиндром");
}