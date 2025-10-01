using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANPruefer
{
        public class Iban
        {
            private string bankleitnummer;
            private string kontonummer;
            private string laendercodezahl;
            private string laendercode;
            private string pruefziffer;
            private string ibannummer;
            private string countrydigits;
            

        public string Bankleitnummer
        {
            get { return bankleitnummer; }
            set { bankleitnummer = value; }
        }

        public string Kontonummer
        {
            get { return kontonummer; }
            set { kontonummer = value; }
        }

        public string Laendercodezahl
        {
            get { return laendercodezahl;}
            set { laendercodezahl = value; }
        }

        public string Pruefziffer
        {
          get { return pruefziffer; }
          set { pruefziffer = value; }
        } 

        public string Laendercode
        {
            get { return laendercode; }
        }

        public string Ibannummer
        {
            get { return ibannummer; }
            set { ibannummer = value; }
        }

        public string Countrydigits
        {
            get { return countrydigits; }
            set {  countrydigits = value; }
        }

        
        public Iban(string bankleitnummer, string kontonummer, string laendercodezahl, string pruefziffer, string laendercode, string ibannummer, string countrydigits)
        {
            Pruefziffer = pruefziffer;
            Bankleitnummer = bankleitnummer;
            Kontonummer = kontonummer;
            Ibannummer = ibannummer;
           

        }
         
        }
}
