using System.Collections.Generic;
using UML;

Manager manager = new Manager(2000);
Departement departement = new Departement(manager);
var Hubert = departement.GetEmployeeinlist("Hubert", 3000);
var Flip = departement.GetEmployeeinlist("Philipp", 5000);
var salaries = departement.GetSalaryEmployees();
departement.SetManager(manager);
manager.SetDepartment(departement);
var bonus = manager.GetBonus();
var manSalary = manager.GetManagerSalary();
var Jörn = departement.GetEmployeeinlist("Jörn", manSalary);
var wageExpenses = departement.getWageExpenses();
Console.WriteLine($"Die Mitarbeiter verdienen insgesamt {wageExpenses} CHF und der Manager verdient {manSalary} CHF. Dabei ist ein Bonus von {bonus} CHF inkludiert. Die Lohnkosten belaufen sich auf {wageExpenses} CHF");
