using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Payroll
    {
        public double calculatePay(HourlyEmployee employee)
        {
            return employee.calculatePay();
        }

        public double calculatePay(SalariedEmployee employee)
        {
            return employee.calculatePay();
        }
    }
}
