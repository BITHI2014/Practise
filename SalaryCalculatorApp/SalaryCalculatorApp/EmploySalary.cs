using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    internal class EmploySalary
    {
        public string employeeName;
        public double basicAmount;
        public double houseRent;
        public double medicalAllowance;
        public double salary;

        public double ShowingSalary()
        {
            return basicAmount + GetHouseRent() + GetMedicalAllowance();


        }

        private double GetMedicalAllowance()
        {
            return (basicAmount*medicalAllowance)/100;
        }

        private double GetHouseRent()
        {
            return (basicAmount*houseRent)/100;
        }
    }
}  