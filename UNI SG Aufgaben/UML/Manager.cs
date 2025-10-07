using UML;
namespace UML
{
    public class Manager : Employee
    {
        private int bonus;
        public int Bonus { get { return bonus; } set { bonus = value; } }
        public int getBonus()
        {
            return bonus;
        }
        public int getManagerSalary()
        {
            int gehalt = Salary + Bonus;
            return gehalt;
        }
        public Manager(string name, int bonus, int salary)
        {
            Name = name;
            Bonus = bonus;
            Salary = salary;
        }
        public Manager()
        {
        }
    }
}
