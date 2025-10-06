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
        public int getGehalt(int bonus)
        {
            int gehalt = Salary + Bonus;
            return gehalt;
        }
        public Manager(string name)
        {
            Name = name;
            Bonus = bonus;
        }
    }
}
