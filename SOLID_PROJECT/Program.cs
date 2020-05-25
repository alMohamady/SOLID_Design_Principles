using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PROJECT
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new PermanentEmployee(1, "Ahmed");

            Console.WriteLine("Emplyee: {0}  Bouns: {1} ", employee.ToString()
                , employee.CalculateBonus(100000).ToString());


            Employee employee2 = new TempEmployee(1, "Mohamed");

            Console.WriteLine("Emplyee: {0}  Bouns: {1} ", employee2.ToString()
                , employee2.CalculateBonus(100000).ToString());

            Console.ReadKey(true);

        }
    }
}
