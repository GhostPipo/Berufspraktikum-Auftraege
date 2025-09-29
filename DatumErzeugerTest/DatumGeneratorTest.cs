using System.Security.Cryptography.X509Certificates;
using DateFormat;
using Datumerzeuger;

namespace DatumErzeugerTest
{
    [TestClass]
    public sealed class DatumGeneratorTest
    {

    // CH VALIDATION
        [TestMethod]
        public void Datum_FormatDatum_CH_AreEqual()
        {
            // AreEqual Validation
            
            //arrange

            int dayCH1 = 12;
            int monthCH1 = 1;
            int yearCH1 = 2001;
            string formatCH1 = "CH";
            string expectedFormatCH1 = "CH-Format\n12.01.2001";

            //act

            string formatCH3 = Datumformater.FormatDatum(12, 1, 2001, "CH");

            //assert

            Assert.AreEqual(expectedFormatCH1, formatCH3);

        }

        [TestMethod]
        public void Datum_FormatDatum_CH_AreNotEqual()
        {

            //arrange

            int dayCH2 = 13;
            int monthCH2 = 11;
            int yearCH2 = 2003;
            string formatCH2 = "CH";
            string expectedFormatCH2 = "CH-Format\n11/13/2003";

            //act

            string formatCH3 = Datumformater.FormatDatum(12, 11, 2003, "CH");

            //assert

            Assert.AreNotEqual(expectedFormatCH2, formatCH3);
        }

        // US VALIDATION
        [TestMethod]
        public void Datum_FormatDatum_US_AreEqual()
        {
            // AreEqual Validation

            //arrange

            int dayUS1 = 12;
            int monthUS1 = 1;
            int yearUS1 = 2001;
            string formaUS1 = "US";
            string expectedFormatUS1 = "US-Format\n01/12/2001";

            //act

            string formatUS2 = Datumformater.FormatDatum(12, 1, 2001, "US");

            //assert

            Assert.AreEqual(expectedFormatUS1, formatUS2);

        }

        [TestMethod]
        public void Datum_FormatDatum_US_AreNotEqual()
        {

            //arrange

            int dayUS2 = 13;
            int monthUS2 = 11;
            int yearUS2 = 2003;
            string formatUS3 = "US";
            string expectedFormatUS2 = "US-Format\n13/11/2003";

            //act

            string formatUS4 = Datumformater.FormatDatum(12, 11, 2003, "US");

            //assert

            Assert.AreNotEqual(expectedFormatUS2, formatUS4);
        }

        [TestMethod]
        public void Datum_FormatDatum_ISO_AreEqual()
        {
            // AreEqual Validation

            //arrange

            int dayISO1 = 12;
            int monthISO1 = 1;
            int yearISO1 = 2001;
            string formatISO1 = "ISO";
            string expectedFormatISO1 = "ISO-Format\n2001-01-12";

            //act

            string formatISO2 = Datumformater.FormatDatum(12, 1, 2001, "ISO");

            //assert

            Assert.AreEqual(expectedFormatISO1, formatISO2);

        }

        [TestMethod]
        public void Datum_FormatDatum_ISO_AreNotEqual()
        {

            //arrange

            int dayISO2 = 13;
            int monthISO2 = 11;
            int yearISO2 = 2003;
            string formatISO2 = "ISO";
            string expectedFormatISO2 = "ISO-Format\n2003-13-11";

            //act

            string formatISO3 = Datumformater.FormatDatum(12, 11, 2003, "ISO");

            //assert

            Assert.AreNotEqual(expectedFormatISO2, formatISO3);
        }


    }
}
