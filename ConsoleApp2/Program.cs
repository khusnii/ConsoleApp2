
using ConsoleApp2.Models;

Payroll payroll = new Payroll();

HourlyEmployee employee = new HourlyEmployee();



var num = payroll.calculatePay(employee);

Console.WriteLine(num);