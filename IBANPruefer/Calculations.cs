using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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

    }
}
