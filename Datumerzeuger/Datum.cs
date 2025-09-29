using System.Formats.Asn1;

namespace DateFormat
{
    public class Datum
    {
        public int tag ;
        public int monat;
        public int jahr;

        public int Day
        {
            get { return tag; }
            set { tag = value; }
        }

        public int Month
        {
            get { return monat; }
            set { monat = value; }
        }

        public int Year
        {
            get { return jahr; }
            set { jahr = value; }
        }

        public string format;

        public string Format
        {
            get { return format; }
        }




        public Datum(int day, int month, int year, string format)
        {
            Day = day;
            Month = month;
            Year = year;
       
        }
    }
}