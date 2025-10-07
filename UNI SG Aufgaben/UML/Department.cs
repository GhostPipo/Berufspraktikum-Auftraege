namespace UML
{
    public class Departement
    {
        private List<Employee> employeelist = new List<Employee>();
        public List<Employee> Employeelist { get { return employeelist; } set { employeelist = value;} }
        public int getWageExpenses(int man)
        {
            Manager manager = new Manager();
            int sum = employeelist.Sum(employeelist => employeelist.Salary);
            return sum + man;
        }
        public Employee GetEmployeelist(string name, int salary)
        {
            var employee = new Employee(name, salary);
            employeelist.Add(new Employee(name, salary));
            return employee;
        }
        public Departement(List<Employee> employeelist)
        {
            Employeelist = employeelist;
        }
        public Departement()
        {
        }
    }
}
