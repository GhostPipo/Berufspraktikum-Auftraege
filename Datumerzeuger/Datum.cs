using System.Formats.Asn1;

namespace DateFormat
{
    public class Datum
    {
        public int day ;
        public int month;
        public int year;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
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