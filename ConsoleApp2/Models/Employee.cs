

namespace ConsoleApp2.Models
{


    public class Employee: IEmployeeGettersalary, IEmployeeGetterHourlyRate
    {
        private double hourlyRate = 150;
        private double salary = 100;

        public double getHourlyRate()
        {
            return hourlyRate;
        }

        public double getSalary()
        {
            return salary;
        }
    }
}
