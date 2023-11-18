using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Task_3
{
    
    internal class Program
    {
       
      static void Main()
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = functionAkkerma(m, n);
        Console.WriteLine($"Значение функции Аккермана A({m}, {n}): {result}");
    }

    static int functionAkkerma(int m, int n)
    {
        if (m == 0){
            return n + 1;
        }
        else if(m > 0 && n == 0){
            return functionAkkerma(m - 1, 1);

        }
        else if (m > 0 && n > 0){
            return functionAkkerma(m - 1, functionAkkerma(m, n - 1));
        }
        else{
            return 0;
        }
    }
    }
}
