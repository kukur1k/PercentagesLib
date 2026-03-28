using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcentCalculation
{
    public static class ProcentCalculation
    {
        //нахождение процента от числа
        public static double GetProcentByNumber(double number, double procent)
        {
            try
            {
                return number * procent * 0.01;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            
        }

        // исзодное число по проценту и значению
        public static double GetNumberByProcent(double procent, double NumberOfProcent)
        {
            if (Math.Abs(NumberOfProcent / procent) < 1e-9)
            {
                Console.WriteLine("Division by zero -- has return -1");
                return -1;
            }

            return (NumberOfProcent / procent) * 100;
            

        }

        //процент, который первое число составляет от второго
        public static double GetProcentOccourencebyNumbers(double valA, double valB)
        {

            if (Math.Abs(valA / valB) < 1e-9)
            {
                Console.WriteLine("Division by zero -- has return -1");
                return -1;
            }
            return (valA / valB) * 100;

            
        }
    }
}
