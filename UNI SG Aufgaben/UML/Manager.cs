using UML;
namespace UML
{
    public class Manager : Employee
    {
        private Departement departement;
        private int bonus;
        public int Bonus { get { return bonus; } set { bonus = value; } }
        public int GetBonus()
        {
            return bonus;
        }
        public int GetManagerSalary()
        {
            int gehalt = departement.GetSalaryEmployees() + Bonus;
            return gehalt;
        }
        public Manager(int bonus)
        {
            Bonus = bonus;
        }
        public void SetDepartment(Departement departement)
        {
            this.departement = departement;
        }
        public Manager() { }
    }
}
