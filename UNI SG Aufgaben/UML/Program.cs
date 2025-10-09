using System.Collections.Generic;
using UML;
//arrange
Manager manager = new Manager(2000);
Departement departement = new Departement(manager);
List<string> employees = new List<string>();
List<string> employee = departement.GetEmployeesfromList(employees);
//act
departement.GetEmployeeinlist("Hubert", 3000);
departement.GetEmployeeinlist("Philipp", 5000);
departement.GetSalaryEmployees();
departement.SetManager(manager);
manager.SetDepartment(departement);
var bonus = manager.GetBonus();
var managerSalary = manager.GetManagerSalary();
departement.GetEmployeeinlist("Jörn", managerSalary);
var wageExpenses = departement.getWageExpenses();
//assert
foreach (var e in employee)
{
    Console.WriteLine(e);
}
Console.WriteLine($"der Manager verdient {managerSalary} CHF." +
                  $"Dabei ist ein Bonus von {bonus} CHF inkludiert." +
                  $"Die Lohnkosten belaufen sich auf {wageExpenses} CHF");
