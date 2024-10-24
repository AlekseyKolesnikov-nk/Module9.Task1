using Module9.Task1;
using System;

public static class Programm
{
    public static void Main(string[] args)
    {
        var arrayException = new List<Exception>() { new ArgumentException(), new FormatException(), new ArgumentOutOfRangeException(), new DivideByZeroException(), new() };
        foreach (var item in arrayException)
        {
            bool bad = true;
            while (bad)
            {
                try
                {
                    Exceptions.NumberExcept();
                    Console.WriteLine("Вы угадали - число 7");
                    //bad = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            break;
        }
    }
}