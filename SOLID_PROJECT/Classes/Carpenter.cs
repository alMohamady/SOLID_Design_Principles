using SOLID_PROJECT.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PROJECT.Classes
{
    class Carpenter : IWorker
    {
        public void DoWork()
        {
            FixWindows();
        }

        public void FixWindows() 
        {
            Console.WriteLine("Fix Windows");
        }
    }
}
