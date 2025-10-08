using UML;
namespace UMLTest
{
    [TestClass]
    public sealed class UMLUnitTests
    {
        [TestMethod]
        public void UML_GetWageExpenses_Test_AreEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            var salaryHubert = departement.GetEmployeeinlist("Hubert", 1834);
            Manager manager = new Manager(2000);
            var man = manager.GetManagerSalary();
            int expectedResult = 9632;
            //act
            int wageexpenses = departement.getWageExpenses();
            //assert
            Assert.AreEqual(expectedResult, wageexpenses);
        }
        [TestMethod]
        public void UML_GetWageExpenses_Test_AreNotEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var employer = departement.GetEmployeeinlist("Philipp", 3254);
            var salary = departement.GetEmployeeinlist("Hubert", 1834);
            Manager manager = new Manager(2000);
            var man = manager.GetManagerSalary();
            int expectedResult = 67;
            //act
            int wageexpenses = departement.getWageExpenses();
            //assert
            Assert.AreNotEqual(expectedResult, wageexpenses);
        }
        [TestMethod]
        public void UML_GetSalary_Test_AreEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            int expectedResult = 3254 + 1834;
            int salary = departement.GetSalaryEmployees();
            //act
            var Flip = departement.GetEmployeeinlist("Philipp", 3254);
            var  Hubert = departement.GetEmployeeinlist("Hubert", 1834);

            //assert
            Assert.AreEqual(expectedResult, salary);
        }
        [TestMethod]
        public void UML_GetSalary_Test_AreNotEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            int expectedResult = 1889 + 20489; 
            //act
            var Flip = departement.GetEmployeeinlist("Philipp", 3254);
            var Hubert = departement.GetEmployeeinlist("Hubert", 1834);
            int salary = departement.GetSalaryEmployees();
            //assert
            Assert.AreNotEqual(expectedResult, salary);
        }
        [TestMethod]
        public void UML_GetManagerSalary_Test_AreEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            Manager manager = new Manager(2000);
            int expectedResult = 5254;
            //act
            var man = manager.GetManagerSalary();
            //assert
            Assert.AreEqual(expectedResult, man);
        }
        [TestMethod]
        public void UML_GetManagerSalary_Test_AreNotEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            Manager manager = new Manager(2000);
            int expectedResult = 5255;
            //act
            var man = manager.GetManagerSalary();
            //assert
            Assert.AreNotEqual(expectedResult, man);
        }
        [TestMethod]
        public void UML_GetBonus_Test_AreEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            Manager manager = new Manager(2000);
            int expectedResult = 2000;
            //act
            var bonus = manager.GetBonus();
            //assert
            Assert.AreEqual(expectedResult, bonus);
        }
        [TestMethod]
        public void UML_GetBonus_Test_AreNotEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            Manager manager = new Manager(2005);
            int expectedResult = 2000;
            //act
            var bonus = manager.GetBonus();
            //assert
            Assert.AreNotEqual(expectedResult, bonus);
        }
    }
}
