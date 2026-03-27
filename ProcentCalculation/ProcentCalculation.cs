using System;
using System.Collections.Generic;
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
            try
            {
                return (NumberOfProcent / procent) * 100;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

        }

        //процент, который первое число составляет от второго
        public static double GetProcentOccourencebyNumbers(double valB, double valA)
        {
            try
            {
                return (valA / valB) * 100;
            }
            catch (Exception e)
            { 
                Console.Write(e.Message);
                return -1;
            }

            
        }
    }
}
