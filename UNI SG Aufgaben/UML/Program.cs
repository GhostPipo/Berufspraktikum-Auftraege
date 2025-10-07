using System.Collections.Generic;
using UML;

namespace UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Departement departement = new Departement();
            var salaryHubert = departement.GetEmployeeinlist("Hubert", 1834);
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            var salary = (salaryFlip + salaryHubert) / 2;
            Manager manager = new Manager("Jörn Stein", 2000, salary);
            var bonus = manager.getBonus();
            var man = manager.getManagerSalary();
            var wageExpenses = departement.getWageExpenses(man);
            Console.WriteLine($"Die Mitarbeiter verdienen insgesamt {wageExpenses} CHF und der Manager verdient {man} CHF. Dabei ist ein Bonus von {bonus} CHF inkludiert. Die Lohnkosten belaufen sich auf {wageExpenses} CHF");
        }
    }
}
