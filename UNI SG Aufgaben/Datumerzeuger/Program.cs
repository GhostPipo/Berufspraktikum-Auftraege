using System.Diagnostics;
using System.Formats.Asn1;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using DateFormat;



namespace Datumerzeuger
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string date = Datumformater.FormatDatum(12, 10, 2000, "ISO");
            Console.WriteLine(date);









        }
    }
}
