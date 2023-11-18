using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Task_2
{
    
    internal class Program
    {
       
      static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = CalculateSumInRange(m, n);
        Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n}: {sum}");
    }

    static int CalculateSumInRange(int start, int end)
    {
        if (start > end)
        {
            return 0;
        }

        return start + CalculateSumInRange(start + 1, end);
    }
    }
}