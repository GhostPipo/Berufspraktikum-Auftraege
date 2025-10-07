using System.Collections.Generic;
using UML;

namespace UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Departement departement = new Departement();
            var employer = departement.GetEmployeelist("Philipp", 3254);
            departement.GetEmployeelist("Hubert", 1834);
            var salary = employer.getMonatslohn();
            Manager manager = new Manager("Jörn Stein", 2000, salary);
            var bonus = manager.getBonus();
            var man = manager.getGehalt();
            var wageExpenses = departement.getWageExpenses(man);
            Console.WriteLine($"Die Mitarbeiter verdienen insgesamt {salary} CHF und der Manager verdient {man} CHF. Dabei ist ein Bonus von {bonus} CHF inkludiert. Die Lohnkosten belaufen sich auf {wageExpenses} CHF");
        }
    }
}
