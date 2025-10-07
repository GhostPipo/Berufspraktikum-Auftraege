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
            var employer = departement.GetEmployeelist("Philipp", 3254);
            departement.GetEmployeelist("Hubert", 1834);
            var salary = employer.getMonatslohn();
            Manager manager = new Manager("Jörn Stein", 2000, salary);
            var man = manager.getGehalt();
            var wageExpenses = departement.getWageExpenses(man);
            int expectedResult = 10342;
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
            var employer = departement.GetEmployeelist("Philipp", 3254);
            departement.GetEmployeelist("Hubert", 1834);
            var salary = employer.getMonatslohn();
            Manager manager = new Manager("Jörn Stein", 2000, salary);
            var man = manager.getGehalt();
            var wageExpenses = departement.getWageExpenses(man);
            int expectedResult = 67;
            //act
            int wageexpenses = departement.getWageExpenses(man);
            //assert
            Assert.AreEqual(expectedResult, wageexpenses);
        }
        [TestMethod]
        public void UML_GetMonatslohn_Test_AreEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var flip = departement.GetEmployeelist("Philipp", 3254);
            var hubert = departement.GetEmployeelist("Hubert", 1834);
            int expectedResultFlip = 3254;
            int expectedResultHubert = 1834;
            //act
            var salaryFlip = flip.getMonatslohn();
            var salaryHubert = hubert.getMonatslohn();
            //assert
            Assert.AreEqual(expectedResultFlip, salaryFlip);
            Assert.AreEqual(expectedResultHubert, salaryHubert);
        }
        [TestMethod]
        public void UML_GetMonatslohn_Test_AreNotEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var flip = departement.GetEmployeelist("Philipp", 3254);
            var hubert = departement.GetEmployeelist("Hubert", 1834);
            int expectedResultFlip = 1889;
            int expectedResultHubert = 20489;
            //act
            var salaryFlip = flip.getMonatslohn();
            var salaryHubert = hubert.getMonatslohn();
            //assert
            Assert.AreEqual(expectedResultFlip, salaryFlip);
            Assert.AreEqual(expectedResultHubert, salaryHubert);
        }
        [TestMethod]
        public void UML_GetGehalt_Test_AreEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var flip = departement.GetEmployeelist("Philipp", 3254);
            var salaryFlip = flip.getMonatslohn();
            Manager manager = new Manager("Jörn Stein", 2000, salaryFlip);
            int expectedResult = 5254;
            //act
            var man = manager.getGehalt();
            //assert
            Assert.AreEqual(expectedResult, man);
        }
        [TestMethod]
        public void UML_GetGehalt_Test_AreNotEqual_Nr1()
        {
            //arrange
            Departement departement = new Departement();
            var flip = departement.GetEmployeelist("Philipp", 3254);
            var salaryFlip = flip.getMonatslohn();
            Manager manager = new Manager("Jörn Stein", 2000, salaryFlip);
            int expectedResult = 5255;
            //act
            var man = manager.getGehalt();
            //assert
            Assert.AreEqual(expectedResult, man);
        }
    }
}
