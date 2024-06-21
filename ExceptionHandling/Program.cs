using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5};
            try
            {
                for (int i = 0; i <= numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.ToString());
            }

            finally { numbers = null; }
            Console.WriteLine("numbers:" + numbers);
            Console.ReadLine();

        }
    }
}
