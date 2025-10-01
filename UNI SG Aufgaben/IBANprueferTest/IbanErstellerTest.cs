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
            string expectedResult1 = "CH951234010123049880";
            string expectedResult2 = "Die IBAN ist gültig.";
            string banknumber = "01234";
            string acccountnumber = "010123049880";
            string countryletters = "CH";
            string countrycode = Calculations.GetCountry(expectedResult1);
            string proofsum = Calculations.CreatePruefzahl(banknumber, acccountnumber, countrycode);
            

            //act
            string bban = Calculations.CreateBBAN(banknumber, acccountnumber);
            string iban = Calculations.CreateIban(countryletters, proofsum, bban);
            string isiban = Calculations.ValidateIban(expectedResult1);


            //assert
            Assert.AreEqual(expectedResult1, iban);
            Assert.AreEqual(expectedResult2, isiban);
        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreEqual_Nr2()
        {
            // AreEqual Validation

            //arrange
            string expectedResult1 = "CH4212345200297680912";
            string expectedResult2 = "Die IBAN ist gültig.";
            string banknumber  = "12345";
            string acccountnumber = "200297680912";
            string countryletters  = "CH";
            string countrycode = Calculations.GetCountry(expectedResult1);
            string proofsum = Calculations.CreatePruefzahl(banknumber, acccountnumber, countrycode);

            //act
            string bban = Calculations.CreateBBAN(banknumber, acccountnumber);
            string iban = Calculations.CreateIban(countryletters,proofsum, bban);
            string isiban = Calculations.ValidateIban(expectedResult1);

            //assert
            Assert.AreEqual(expectedResult1, iban);
            Assert.AreEqual(expectedResult2, isiban);
        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreEqual_Nr3()
        {
            // AreEqual Validation

            //arrange
            string expectedResult1 = "CH8023456200987439212";
            string expectedResult2 = "Die IBAN ist gültig.";
            string banknumber  = "23456";
            string acccountnumber = "200987439212";
            string countryletters  = "CH";
            string countrycode = Calculations.GetCountry(expectedResult1);
            string proofsum  = Calculations.CreatePruefzahl(banknumber, acccountnumber, countrycode);

            //act
            string bban = Calculations.CreateBBAN(banknumber, acccountnumber);
            string iban = Calculations.CreateIban(countryletters, proofsum, bban);
            string isiban = Calculations.ValidateIban(expectedResult1);

            //assert
            Assert.AreEqual(expectedResult1, iban);
            Assert.AreEqual(expectedResult2, isiban);
        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreNotEqual_Nr1()
        {
            // AreEqual Validation

            //arrange
            string expectedResult = "CH1923489509223845902";
            string banknumber = "01234";
            string acccountnumber = "010123049880";
            string countrycode = Calculations.GetCountry(expectedResult);
            string countryletters = "CH";
            string proofsum = Calculations.CreatePruefzahl(banknumber, acccountnumber, countrycode);

            //act
            string bban = Calculations.CreateBBAN(banknumber, acccountnumber);
            string iban = Calculations.CreateIban(countryletters, proofsum, bban);

            //assert
            Assert.AreNotEqual(expectedResult, iban);

        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreNotEqual_Nr2()
        {
            // AreEqual Validation

            //arrange
            string expectedResult = "CH9511223344556688779";
            string banknumber = "01234";
            string acccountnumber = "010123049880";
            string countryletters = "CH";
            string countrycode = Calculations.GetCountry(expectedResult);
            string proofsum = Calculations.CreatePruefzahl(banknumber, acccountnumber, countrycode);

            //act
            string bban = Calculations.CreateBBAN(banknumber, acccountnumber);
            string iban = Calculations.CreateIban(countryletters, proofsum, bban);

            //assert
            Assert.AreNotEqual(expectedResult, iban);

        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreNotEqual_Nr3()
        {
            // AreEqual Validation

            //arrange
            string expectedResult = "CH9520293847561029387";
            string banknumber = "01234";
            string acccountnumber = "010123049880";
            string countryletters = "CH";
            string countrycode = Calculations.GetCountry(expectedResult);
            string proofsum = Calculations.CreatePruefzahl(banknumber, acccountnumber, countrycode);

            //act
            string bban = Calculations.CreateBBAN(banknumber, acccountnumber);
            string iban = Calculations.CreateIban(countryletters, proofsum, bban);

            //assert
            Assert.AreNotEqual(expectedResult, iban);

        }



        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreEqualNr1()
        {
            // AreEqual Validation

            //arrange
            string ibannummer = "AT411100000237571500";
            string expectedResult = "Die IBAN ist gültig.";


            //act
            string isIbanValid = Calculations.ValidateIban(ibannummer);

            //assert
            Assert.AreEqual(expectedResult, isIbanValid);

        }

        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreEqualNr2()
        {
            // AreEqual Validation

            //arrange
            string ibannummer2 = "DE911000000001234567890";
            string ExpectedResult2 = "Die IBAN ist ungültig";


            //act
            string isIbanValid2 = Calculations.ValidateIban(ibannummer2);

            //assert
            Assert.AreEqual(ExpectedResult2, isIbanValid2);

        }

        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreEqualNr3()
        {
            // AreEqual Validation

            //arrange
            string ibannummer3 = "CH3580808006438396881";
            string ExpectedResult3 = "Die IBAN ist gültig.";


            //act
            string isIbanValid3 = Calculations.ValidateIban(ibannummer3);

            //assert
            Assert.AreEqual(ExpectedResult3, isIbanValid3);

        }

        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreNotEqualNr1()
        {
            // AreEqual Validation

            //arrange
            string ibannummer4 = "AT411100000237571500";
            string ExpectedResult4 = "Die IBAN ist ungültig";


            //act
            string isIbanValid4 = Calculations.ValidateIban(ibannummer4);

            //assert
            Assert.AreNotEqual(ExpectedResult4, isIbanValid4);

        }

        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreNotEqualNr2()
        {
            // AreEqual Validation

            //arrange
            string ibannummer5 = "CH3580808006438396881";
            string ExpectedResult5 = "Die IBAN ist ungültig";


            //act
            string isIbanValid5 = Calculations.ValidateIban(ibannummer5);

            //assert
            Assert.AreNotEqual(ExpectedResult5, isIbanValid5);

        }

        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreNotEqualNr3()
        {
            // AreEqual Validation

            //arrange
            string ibannummer6 = "DE911000000001234567890";
            string ExpectedResult6 = "Die IBAN ist gültig.";


            //act
            string isIbanValid6 = Calculations.ValidateIban(ibannummer6);

            //assert
            Assert.AreNotEqual(ExpectedResult6, isIbanValid6);

        }


        [TestMethod]
        public void Ibanpruefer_getCountry_AreEqualNr1()
        {
            // AreEqual Validation

            //arrange
            string ibannummer1 = "CH3580808006438396881";
            string ExpectedResult1 = "1217";


            //act
            string Countrydigit1 = Calculations.GetCountry(ibannummer1);

            //assert
            Assert.AreEqual(ExpectedResult1, Countrydigit1);

        }

        [TestMethod]
        public void Ibanpruefer_getCountry_AreEqualNr2()
        {
            // AreEqual Validation

            //arrange
            string ibannummer2 = "AT3580808006438396881";
            string ExpectedResult2 = "1029";


            //act
            string Countrydigit2 = Calculations.GetCountry(ibannummer2);

            //assert
            Assert.AreEqual(ExpectedResult2, Countrydigit2);

        }

        [TestMethod]
        public void Ibanpruefer_getCountry_AreNotEqualNr1()
        {
            // AreEqual Validation

            //arrange
            string ibannummer3 = "CH3580808006438396881";
            string ExpectedResult3 = "1314";


            //act
            string Countrydigit3 = Calculations.GetCountry(ibannummer3);

            //assert
            Assert.AreNotEqual(ExpectedResult3, Countrydigit3);

        }

        [TestMethod]
        public void Ibanpruefer_getCountry_AreNotEqualNr2()
        {
            // AreEqual Validation

            //arrange
            string ibannummer4 = "AT3580808006438396881";
            string ExpectedResult4 = "1314";


            //act
            string Countrydigit4 = Calculations.GetCountry(ibannummer4);

            //assert
            Assert.AreNotEqual(ExpectedResult4, Countrydigit4);

        }



    }
}
