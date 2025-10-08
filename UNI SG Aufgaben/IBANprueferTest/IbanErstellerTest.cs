using System.Diagnostics.Metrics;
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
            Calculations BBAN = new Calculations();
            Calculations proofnumber = new Calculations();
            Calculations IBAN = new Calculations();
            Calculations country = new Calculations();
            Calculations isValid = new Calculations();

            string expectedResult1 = "CH9501234010123049880";
            bool expectedResult2 = true;
            string banknumber = "01234";
            string acccountnumber = "010123049880";
            string calcbban = BBAN.CreateBBAN(banknumber, acccountnumber);
            string countryletters = "CH";
            string countrycode = country.GetCountry(expectedResult1);
            string proofsum = proofnumber.CreatePruefzahl(calcbban, countrycode);

            //act
            string bban = BBAN.CreateBBAN(banknumber, acccountnumber);
            string iban = IBAN.CreateIban(countryletters, proofsum, bban);
            bool isiban = isValid.ValidateIban(expectedResult1);

            //assert
            Assert.AreEqual(expectedResult1, iban);
            Assert.AreEqual(expectedResult2, isiban);
        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreEqual_Nr2()
        {
            // AreEqual Validation

            //arrange
            Calculations BBAN = new Calculations();
            Calculations proofnumber = new Calculations();
            Calculations IBAN = new Calculations();
            Calculations country = new Calculations();
            Calculations isValid = new Calculations();

            string expectedResult1 = "CH4212345200297680912";
            bool expectedResult2 = true;
            string banknumber  = "12345";
            string acccountnumber = "200297680912";
            string calcbban = BBAN.CreateBBAN(banknumber, acccountnumber);
            string countryletters  = "CH";
            string countrycode = country.GetCountry(expectedResult1);
            string proofsum = proofnumber.CreatePruefzahl(calcbban, countrycode);

            //act
            string bban = BBAN.CreateBBAN(banknumber, acccountnumber);
            string iban = IBAN.CreateIban(countryletters, proofsum, bban);
            bool isiban = isValid.ValidateIban(expectedResult1);

            //assert
            Assert.AreEqual(expectedResult1, iban);
            Assert.AreEqual(expectedResult2, isiban);
        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreEqual_Nr3()
        {
            // AreEqual Validation

            //arrange
            Calculations BBAN = new Calculations();
            Calculations proofnumber = new Calculations();
            Calculations IBAN = new Calculations();
            Calculations country = new Calculations();
            Calculations isValid = new Calculations();

            string expectedResult1 = "CH4423456200987439212";
            bool expectedResult2 = true;
            string banknumber  = "23456";
            string acccountnumber = "200987439212";
            string calcbban = BBAN.CreateBBAN(banknumber, acccountnumber);
            string countryletters  = "CH";
            string countrycode = country.GetCountry(expectedResult1);
            string proofsum = proofnumber.CreatePruefzahl(calcbban, countrycode);

            //act
            string bban = BBAN.CreateBBAN(banknumber, acccountnumber);
            string iban = IBAN.CreateIban(countryletters, proofsum, bban);
            bool isiban = isValid.ValidateIban(expectedResult1);

            //assert
            Assert.AreEqual(expectedResult1, iban);
            Assert.AreEqual(expectedResult2, isiban);
        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreNotEqual_Nr1()
        {
            // AreEqual Validation

            //arrange
            Calculations BBAN = new Calculations();
            Calculations proofnumber = new Calculations();
            Calculations IBAN = new Calculations();
            Calculations country = new Calculations();

            string expectedResult = "CH1923489509223845902";
            string banknumber = "01234";
            string acccountnumber = "010123049880";
            string calcbban = BBAN.CreateBBAN(banknumber, acccountnumber);
            string countryletters = "CH";
            string countrycode = country.GetCountry(expectedResult);
            string proofsum = proofnumber.CreatePruefzahl(calcbban, countrycode);

            //act
            string bban =BBAN.CreateBBAN(banknumber, acccountnumber);
            string iban = IBAN.CreateIban(countryletters, proofsum, bban);

            //assert
            Assert.AreNotEqual(expectedResult, iban);
        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreNotEqual_Nr2()
        {
            // AreEqual Validation

            //arrange
            Calculations BBAN = new Calculations();
            Calculations proofnumber = new Calculations();
            Calculations IBAN = new Calculations();
            Calculations country = new Calculations();

            string expectedResult = "CH9511223344556688779";
            string banknumber = "01234";
            string acccountnumber = "010123049880";
            string calcbban = BBAN.CreateBBAN(banknumber, acccountnumber);
            string countryletters = "CH";
            string countrycode = country.GetCountry(expectedResult);
            string proofsum = proofnumber.CreatePruefzahl(calcbban, countrycode);

            //act
            string bban = BBAN.CreateBBAN(banknumber, acccountnumber);
            string iban = IBAN.CreateIban(countryletters, proofsum, bban);

            //assert
            Assert.AreNotEqual(expectedResult, iban);
        }

        [TestMethod]
        public void Ibanpruefer_CreateIban_AreNotEqual_Nr3()
        {
            // AreEqual Validation

            //arrange
            Calculations BBAN = new Calculations();
            Calculations proofnumber = new Calculations();
            Calculations IBAN = new Calculations();
            Calculations country = new Calculations();

            string expectedResult = "CH9520293847561029387";
            string banknumber = "01234";
            string acccountnumber = "010123049880";
            string calcbban = BBAN.CreateBBAN(banknumber, acccountnumber);
            string countryletters = "CH";
            string countrycode = country.GetCountry(expectedResult);
            string proofsum = proofnumber.CreatePruefzahl(calcbban, countrycode);

            //act
            string bban = BBAN.CreateBBAN(banknumber, acccountnumber);
            string iban = IBAN.CreateIban(countryletters, proofsum, bban);

            //assert
            Assert.AreNotEqual(expectedResult, iban);
        }

        //IbanValidator

        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreEqualNr1()
        {
            // AreEqual Validation

            //arrange
            Calculations isValid = new Calculations();

            string ibannummer = "AT411100000237571500";
            bool expectedResult = true;

            //act
            bool isIbanValid = isValid.ValidateIban(ibannummer);

            //assert
            Assert.AreEqual(expectedResult, isIbanValid);
        }

        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreEqualNr2()
        {
            // AreEqual Validation

            //arrange
            Calculations isValid = new Calculations();

            string ibannummer  = "DE911000000001234567890";
            bool expectedResult = false;

            //act
            bool isIbanValid  = isValid.ValidateIban(ibannummer);

            //assert
            Assert.AreEqual(expectedResult , isIbanValid);
        }

        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreEqualNr3()
        {
            // AreEqual Validation

            //arrange
            Calculations isValid = new Calculations();

            string ibannummer = "CH3580808006438396881";
            bool expectedResult = true;

            //act
            bool isIbanValid = isValid.ValidateIban(ibannummer);

            //assert
            Assert.AreEqual(expectedResult, isIbanValid);
        }

        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreNotEqualNr1()
        {
            // AreEqual Validation

            //arrange
            Calculations isValid = new Calculations();

            string ibannummer = "AT411100000237571500";
            bool expectedResult = false;

            //act
            bool isIbanValid = isValid.ValidateIban(ibannummer);

            //assert
            Assert.AreNotEqual(expectedResult, isIbanValid);
        }

        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreNotEqualNr2()
        {
            // AreEqual Validation

            //arrange
            Calculations isValid = new Calculations();

            string ibannummer = "CH3580808006438396881";
            bool expectedResult = false;


            //act
            bool isIbanValid = isValid.ValidateIban(ibannummer);

            //assert
            Assert.AreNotEqual(expectedResult, isIbanValid);
        }

        [TestMethod]
        public void Ibanpruefer_Ibanvalidator_AreNotEqualNr3()
        {
            // AreEqual Validation

            //arrange
            Calculations isValid = new Calculations();

            string ibannummer = "DE911000000001234567890";
            bool expectedResult = true;


            //act
           bool isIbanValid = isValid.ValidateIban(ibannummer);

            //assert
            Assert.AreNotEqual(expectedResult, isIbanValid);
        }

        [TestMethod]
        public void Ibanpruefer_getCountry_AreEqualNr1()
        {
            // AreEqual Validation

            //arrange
            Calculations country = new Calculations();

            string ibannummer = "CH3580808006438396881";
            string expectedResult = "1217";

            //act
            string countrydigit = country.GetCountry(ibannummer);

            //assert
            Assert.AreEqual(expectedResult, countrydigit);
        }

        [TestMethod]
        public void Ibanpruefer_getCountry_AreEqualNr2()
        {
            // AreEqual Validation

            //arrange
            Calculations country = new Calculations();

            string ibannummer = "AT3580808006438396881";
            string expectedResult = "1029";

            //act
            string countrydigit = country.GetCountry(ibannummer);

            //assert
            Assert.AreEqual(expectedResult, countrydigit);
        }

        [TestMethod]
        public void Ibanpruefer_getCountry_AreNotEqualNr1()
        {
            // AreEqual Validation

            //arrange
            Calculations country = new Calculations();

            string ibannummer = "CH3580808006438396881";
            string expectedResult = "1314";


            //act
            string countrydigit = country.GetCountry(ibannummer);

            //assert
            Assert.AreNotEqual(expectedResult, countrydigit);
        }

        [TestMethod]
        public void Ibanpruefer_getCountry_AreNotEqualNr2()
        {
            // AreEqual Validation

            //arrange
            Calculations country = new Calculations();

            string ibannummer = "AT3580808006438396881";
            string expectedResult = "1314";

            //act
            string countrydigit = country.GetCountry(ibannummer);

            //assert
            Assert.AreNotEqual(expectedResult, countrydigit);
        }
    }
}
