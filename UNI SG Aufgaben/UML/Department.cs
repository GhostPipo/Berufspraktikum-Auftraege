using UML;
namespace UML
{
    public class Departement
    {
        private Manager manager;
        private List<Employee> employeelist = new List<Employee>();
        public int getWageExpenses()
        {
            int sum = employeelist.Sum(employeelist => employeelist.Salary);
            return sum;
        }
        public List<Employee> GetEmployeeinlist(string name, int salary)
        {
            employeelist.Add(new Employee(name, salary));
            return employeelist;
        }
        public int GetSalaryEmployees()
        {
            int sum = employeelist.Sum(employeelist => employeelist.Salary);
            if (employeelist.Count >= 2)
            {
                var salariescollective = sum / employeelist.Count;
                return salariescollective;
            }   
            else
            {
                return sum;
            }
        }
        public void SetManager(Manager manager)
        {
            this.manager = manager;
        }
        public List<string> GetEmployeesfromList(List<string> employees)
        {
            int i;
            for (i = 0; i < employeelist.Count(); i++)
            {
                employees.Add($"Employee: {employeelist[i].Name}; Salary: {employeelist[i].Salary}");
            }
            return employees;
        }
        public Departement(Manager manager)
        {
            this.manager = manager;
        }
        public Departement() { }
    }
}
