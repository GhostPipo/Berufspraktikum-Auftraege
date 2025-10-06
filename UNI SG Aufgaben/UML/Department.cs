namespace UML
{
    public class Departement
    {
        private List<Employee> employeelist = new List<Employee>
        { new Employee("Philipp", 4500), new Employee("Nathan", 271000), new Employee("Razar", 899)};
        public List<Employee> Employeelist { get { return employeelist; } set { employeelist = value;} }
        public int getWageExpenses()
        {
            int sum = employeelist.Sum(employeelist => employeelist.Salary);
            return sum;
        }
    }
}
