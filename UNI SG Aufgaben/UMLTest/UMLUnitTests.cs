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
            var salary = (salaryFlip + salaryHubert) / 2;
            Manager manager = new Manager("Jörn Stein", 2000, salary);
            var man = manager.getManagerSalary();
            int expectedResult = 9632;
            //act
            int wageexpenses = departement.getWageExpenses(man);
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
            Manager manager = new Manager("Jörn Stein", 2000, salary);
            var man = manager.getManagerSalary();
            int expectedResult = 67;
            //act
            int wageexpenses = departement.getWageExpenses(man);
            //assert
            Assert.AreNotEqual(expectedResult, wageexpenses);
        }
        [TestMethod]
        public void UML_GetSalary_Test_AreEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            int expectedResultFlip = 3254;
            int expectedResultHubert = 1834;
            //act
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            var salaryHubert = departement.GetEmployeeinlist("Hubert", 1834);
            //assert
            Assert.AreEqual(expectedResultFlip, salaryFlip);
            Assert.AreEqual(expectedResultHubert, salaryHubert);
        }
        [TestMethod]
        public void UML_GetSalary_Test_AreNotEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            int expectedResultFlip = 1889;
            int expectedResultHubert = 20489;
            //act
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            var salaryHubert = departement.GetEmployeeinlist("Hubert", 1834);
            //assert
            Assert.AreNotEqual(expectedResultFlip, salaryFlip);
            Assert.AreNotEqual(expectedResultHubert, salaryHubert);
        }
        [TestMethod]
        public void UML_GetManagerSalary_Test_AreEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            Manager manager = new Manager("Jörn Stein", 2000, salaryFlip);
            int expectedResult = 5254;
            //act
            var man = manager.getManagerSalary();
            //assert
            Assert.AreEqual(expectedResult, man);
        }
        [TestMethod]
        public void UML_GetManagerSalary_Test_AreNotEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            Manager manager = new Manager("Jörn Stein", 2000, salaryFlip);
            int expectedResult = 5255;
            //act
            var man = manager.getManagerSalary();
            //assert
            Assert.AreNotEqual(expectedResult, man);
        }
        [TestMethod]
        public void UML_GetBonus_Test_AreEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            Manager manager = new Manager("Jörn Stein", 2000, salaryFlip);
            int expectedResult = 2000;
            //act
            var bonus = manager.getBonus();
            //assert
            Assert.AreEqual(expectedResult, bonus);
        }
        [TestMethod]
        public void UML_GetBonus_Test_AreNotEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var salaryFlip = departement.GetEmployeeinlist("Philipp", 3254);
            Manager manager = new Manager("Jörn Stein", 2005, salaryFlip);
            int expectedResult = 2000;
            //act
            var bonus = manager.getBonus();
            //assert
            Assert.AreNotEqual(expectedResult, bonus);
        }
        [TestMethod]
        public void UML_GetEmployeeInList_Test_AreEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var expectedResult = 3254;
            //act
            var flip = departement.GetEmployeeinlist("Philipp", 3254);
            //assert
            Assert.AreEqual(expectedResult, flip);
        }
        [TestMethod]
        public void UML_GetEmployeeInList_Test_AreNotEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var expectedResult = 3255;
            //act
            var flip = departement.GetEmployeeinlist("Philipp", 3254);
            //assert
            Assert.AreNotEqual(expectedResult, flip);
        }
    }
}
