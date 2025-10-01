using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using IBANPruefer;

namespace IBANPruefer
{
    public class Calculations
    {


        public static string CreateBban(string bankleitnummer, string kontonummer)
        {
            string bban = $"{bankleitnummer}{kontonummer}";
            return bban;
        }

        public static string CreatePruefzahl(string bankleitnummer, string kontonummer, string laendercodezahl)
        {
            string bbannummer = Calculations.CreateBban(bankleitnummer, kontonummer);
            string langezahl = $"{bbannummer}{laendercodezahl}";
            BigInteger pruefnummer = 98 - (BigInteger.Parse(langezahl) % 97);
            return pruefnummer.ToString();
        }

        public static string CreateIban(string laendercode, string pruefnummer, string bban)
        {
            string iban = $"{laendercode}{pruefnummer}{bban}";
            return iban;
        }

        public static string GetCountry(string ibannummer)
        {
            string result = string.Empty;
            char countrychar1 = ibannummer[0];
            char countrychar2 = ibannummer[1];
            string countryletters = ($"{countrychar1}{countrychar2}").ToString();
            

            switch (countryletters)
            {
                case "DE":
                    result = "1314";
                    break;

                case "CH":
                    result = "1217";
                    break;

                case "AT":
                    result = "1029";
                    break;
            }
            return result;


        }

        public static string ValidateIban(string ibannummer)
        {
            char ibanchar3 = ibannummer[2];
            char ibanchar4 = ibannummer[3];
            string ibandigits = $"{GetCountry(ibannummer)}{ibanchar3}{ibanchar4}";
            string ibanrest = ibannummer.Substring(4);
            string pruefzahlen = $"{ibanrest}{ibandigits}";
            BigInteger x = BigInteger.Parse(pruefzahlen) % 97;

            if (x % 97 == 1)
            {
                return "Die IBAN ist gültig.";
            }
            else
            {
                return "Die IBAN ist ungültig";
                
            }
        }

    }
}
