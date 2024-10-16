using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module9.Task1
{
    public static class Exceptions
    {

/// <summary>
/// Метод с условиями для исключений
/// </summary>
/// <exception cref="FormatException"></exception>              - некорректный формат введенной переменной (нужно int)
/// <exception cref="ArgumentException"></exception>            - введенная переменная 0 символов 
/// <exception cref="ArgumentOutOfRangeException"></exception>  - введенное число вне диапазона (от 0 до 10)
/// <exception cref="DivideByZeroException"></exception>        - введен 0 - деление на 0
/// <exception cref="Exception"></exception>                    - пользовательское исключение (если не 7 - исключение)
        public static void NumberExcept()
        {
            int i;
            bool isInt;

            Console.WriteLine("Введите целое чило от 1 до 10");
            string entered = Console.ReadLine();
            isInt = int.TryParse(entered, out i);
            
            if ( !isInt )
            {
                throw new FormatException();
            }
            if (entered.Length == 0 ) throw new ArgumentException(); 
            
            if (i! < 0 | i! > 10) throw new ArgumentOutOfRangeException();
        
            if (i == 0 ) throw new DivideByZeroException();

            if (i != 7 ) throw new Exception("Не угадал число, попробуй еще раз...");
        }
    }
}
