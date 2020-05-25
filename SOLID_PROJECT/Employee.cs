using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PROJECT
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }

        public Employee()
        { }

        public Employee(int id , string name )
        {
            this.ID = id;
            this.name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}", this.ID, this.name);
        }
    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name) : base(id, name)
        { 
        
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.1M;
        }
    }

    public class TempEmployee : Employee
    {
        public TempEmployee(int id, string name) : base(id, name)
        {

        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.05M;
        }
    }


}
