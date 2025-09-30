using IBANPruefer;

namespace IBANprueferTest
{
    [TestClass]
    public sealed class IbanErstellerTest
    {
        // Iban VALIDATION Equal
        [TestMethod]
        public void Ibanpruefer_CreateIban_AreEqual_Nr1()
        {
            // AreEqual Validation

            //arrange

            string banknumber1 = "01234";
            string acccountnumber1 = "010123049880";
            string countrynumber1 = "121700";
            string countryletters1 = "CH";
            string proofsum1 = "95";
            string ExpectedResult1 = "CH9501234010123049880";


            //act

            string bban = Calculations.CreateBban(banknumber1, acccountnumber1);
            string proofdigits = Calculations.CreatePruefzahl(banknumber1, acccountnumber1, countrynumber1);
            string iban = Calculations.CreateIban(countryletters1, proofsum1, bban);

            //assert
            Assert.AreEqual(ExpectedResult1, iban);

        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreEqual_Nr2()
        {
            // AreEqual Validation

            //arrange

            string banknumber2 = "12345";
            string acccountnumber2 = "200297680912";
            string countrynumber2 = "121700";
            string countryletters2 = "CH";
            string proofsum2 = "42";
            string ExpectedResult2 = "CH4212345200297680912";


            //act

            string bban = Calculations.CreateBban(banknumber2, acccountnumber2);
            string proofdigits = Calculations.CreatePruefzahl(banknumber2, acccountnumber2, countrynumber2);
            string iban = Calculations.CreateIban(countryletters2, proofsum2, bban);

            //assert
            Assert.AreEqual(ExpectedResult2, iban);

        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreEqual_Nr3()
        {
            // AreEqual Validation

            //arrange

            string banknumber3 = "23456";
            string acccountnumber3 = "200987439212";
            string countrynumber3 = "121700";
            string countryletters3 = "CH";
            string proofsum3 = "44";
            string ExpectedResult3 = "CH4423456200987439212";


            //act

            string bban = Calculations.CreateBban(banknumber3, acccountnumber3);
            string proofdigits = Calculations.CreatePruefzahl(banknumber3, acccountnumber3, countrynumber3);
            string iban = Calculations.CreateIban(countryletters3, proofsum3, bban);

            //assert
            Assert.AreEqual(ExpectedResult3, iban);

        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreNotEqual_Nr1()
        {
            // AreEqual Validation

            //arrange

            string banknumber4 = "01234";
            string acccountnumber4 = "010123049880";
            string countrynumber4 = "121700";
            string countryletters4 = "CH";
            string proofsum4 = "95";
            string ExpectedResult4 = "CH1923489509223845902";


            //act

            string bban = Calculations.CreateBban(banknumber4, acccountnumber4);
            string proofdigits = Calculations.CreatePruefzahl(banknumber4, acccountnumber4, countrynumber4);
            string iban = Calculations.CreateIban(countryletters4, proofsum4, bban);

            //assert
            Assert.AreNotEqual(ExpectedResult4, iban);

        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreNotEqual_Nr2()
        {
            // AreEqual Validation

            //arrange

            string banknumber5 = "01234";
            string acccountnumber5 = "010123049880";
            string countrynumber5 = "121700";
            string countryletters5 = "CH";
            string proofsum5 = "95";
            string ExpectedResult5 = "CH9511223344556688779";


            //act

            string bban = Calculations.CreateBban(banknumber5, acccountnumber5);
            string proofdigits = Calculations.CreatePruefzahl(banknumber5, acccountnumber5, countrynumber5);
            string iban = Calculations.CreateIban(countryletters5, proofsum5, bban);

            //assert
            Assert.AreNotEqual(ExpectedResult5, iban);

        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreNotEqual_Nr3()
        {
            // AreEqual Validation

            //arrange

            string banknumber6 = "01234";
            string acccountnumber6 = "010123049880";
            string countrynumber6 = "121700";
            string countryletters6 = "CH";
            string proofsum6 = "95";
            string ExpectedResult6 = "CH9520293847561029387";


            //act

            string bban = Calculations.CreateBban(banknumber6, acccountnumber6);
            string proofdigits = Calculations.CreatePruefzahl(banknumber6, acccountnumber6, countrynumber6);
            string iban = Calculations.CreateIban(countryletters6, proofsum6, bban);

            //assert
            Assert.AreNotEqual(ExpectedResult6, iban);

        }



    }
}
