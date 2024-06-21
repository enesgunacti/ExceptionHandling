using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            //we need to change type becaseu Console.ReadLine() takes string parameters
            int firstNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Second Number");
            //we need to change type becaseu Console.ReadLine() takes string parameters
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            try
            {
                int result = firstNumber / secondNumber;
                throw new Exception("something happened");
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex) // specific exception handling
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex) // generic exception
            {
                Console.WriteLine(ex.ToString());             
            }
            finally
            {
                firstNumber = 0; secondNumber = 0;

                Console.WriteLine("firstNumber : " + firstNumber);
                Console.WriteLine("secondNumber : " + secondNumber);
            }
            Console.ReadLine();
        }
    }
}
