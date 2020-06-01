using SOLID_PROJECT.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PROJECT.Implementation
{
    class ContractEmployee : IEmployee
    {
        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public int ID { get ; set; }
        public string Name { get; set; }

        public decimal GetMinimumSalary()
        {
            return 1000;
        }
    }
}
