namespace UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Departement departement = new Departement();
        Manager manager = new Manager("Jörn Stein");
        var man = manager.getGehalt(2000);
        var wageExpenses = departement.getWageExpenses();
        Console.WriteLine(wageExpenses);
            Console.WriteLine(man);
        }
    }
}
