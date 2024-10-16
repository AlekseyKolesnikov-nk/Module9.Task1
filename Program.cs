using Module9.Task1;
using System;

public static class Programm
{
    public static void Main(string[] args)
    {
        var arrayException = new List<Exception>() { new ArgumentException(), new FormatException(), new ArgumentOutOfRangeException(), new DivideByZeroException(), new() };
        foreach (var item in arrayException)
        {
            while (true)
            {
                try
                {
                    Exceptions.NumberExcept();
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}