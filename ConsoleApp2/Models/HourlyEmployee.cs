

namespace ConsoleApp2.Models
{
    public class HourlyEmployee
    {
      private double hoursWorked ;

        IEmployeeGetterHourlyRate Employee = new Employee();
 
        public double calculatePay()
    {
        return Employee.getHourlyRate() * hoursWorked;
    }
}
}
