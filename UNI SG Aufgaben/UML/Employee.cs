namespace UML
{
    public class Employee
    {
        private string name;
        private int salary;
        public string Name { get { return name; }  set { name = value;} }
        public int Salary { get { return salary; } set { salary = value; } }
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public Employee() { }
    }
}
