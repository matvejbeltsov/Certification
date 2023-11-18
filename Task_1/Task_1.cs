using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Task_1
{
    
    internal class Program
    {
       
       static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Чётные натуральные числа в промежутке от {m} до {n}: ");
        PrintEvenNumbersInRange(m, n);
    }

    static void PrintEvenNumbersInRange(int start, int end)
    {
        if (start > end)
        {
            return;
        }

        if (start % 2 == 0)
        {
            Console.Write($"{start} ");
        }

        PrintEvenNumbersInRange(start + 1, end);
    }
    }
}

