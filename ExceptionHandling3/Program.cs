using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (age < 18)
                    throw new Exception("age must be greater than 18");

                Console.WriteLine("You can sign up the system :)");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
