using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class SalariedEmployee {

    IEmployeeGettersalary EmployeeGettersalary = new Employee();

    public double calculatePay()
    {
        return EmployeeGettersalary.getSalary();
    }
}
}
