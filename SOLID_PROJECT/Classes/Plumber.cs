using SOLID_PROJECT.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PROJECT.Classes
{
    class Plumber :IWorker
    {
        public void DoWork()
        {
            FixBathroom();
        }

        public void FixBathroom()
        {
            Console.WriteLine("Fix Bathroom");
        }


       

    }
}
