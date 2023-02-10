using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger


    {

        public Staff()
        {

        }

        public Staff(string function, int salary, DateTime employmentDate)
        {
            Function = function;
            Salary = salary;
            EmploymentDate = employmentDate;
        }

        public string Function { get; set; }
        public int Salary { get; set; }
        public DateTime EmploymentDate { get; set; }


        public override void PassengerType() { base.PassengerType(); Console.WriteLine(" I am a Staff Member"); }
        public override string ToString()
        {
            return $"EmployementDate: {EmploymentDate}, Function: {Function}, Salary: {Salary}";
        }
    }
}
