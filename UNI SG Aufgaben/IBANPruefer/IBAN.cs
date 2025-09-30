using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANPruefer
{
        public class Iban
        {
            public string bankleitnummer;
            public string kontonummer;
            public string laendercodezahl;
            public string laendercode;
            public string pruefziffer;

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
        public Iban(string bankleitnummer, string kontonummer, string laendercodezahl, string pruefziffer, string laendercode)
        {
            Pruefziffer = pruefziffer;
            Bankleitnummer = bankleitnummer;
            Kontonummer = kontonummer;

        }
         
        }
}
