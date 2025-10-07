namespace UML
{
    public class Departement
    {
        private List<Employee> employeelist = new List<Employee>();
        public int getWageExpenses(int man)
        {
            Manager manager = new Manager();
            int sum = employeelist.Sum(employeelist => employeelist.Salary);
            return sum + man;
        }
        public int GetEmployeeinlist(string name, int salary)
        {
            employeelist.Add(new Employee(name, salary));
            return salary;
        }
        public Departement()
        {
        }
    }
}
