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
        public string CreateBBAN(string bankleitnummer, string kontonummer)
        {
            string bban = $"{bankleitnummer}{kontonummer}";
            return bban;
        }
        public string CreatePruefzahl(string bban, string laendercodezahl)
        {
            Calculations BBAN = new Calculations();
            string langezahl = $"{bban}{laendercodezahl}{"00"}";
            BigInteger pruefnummer = 98 - (BigInteger.Parse(langezahl) % 97);
            return pruefnummer.ToString();
        }
        public string CreateIban(string laendercode, string pruefnummer, string bban)
        {
            string iban = $"{laendercode}{pruefnummer}{bban}";
            return iban;
        }
        public string GetCountry(string ibannummer)
        {
            int ibanlength = ibannummer.Length;
            if (ibannummer != null && ibannummer != "" && ibanlength >1)
            {
                string result = string.Empty;
                char countrychar1 = ibannummer[0];
                char countrychar2 = ibannummer[1];
                string[] letters = [countrychar1.ToString(), countrychar2.ToString()];
                string countryletters = ($"{countrychar1}{countrychar2}").ToString();
                int i = 0;

                foreach (string letter in letters)
                {
                    switch (letter)
                    {
                        case "A": letters[i] = "10"; i++; break;
                        case "B": letters[i] = "11"; i++; break;
                        case "C": letters[i] = "12"; i++; break;
                        case "D": letters[i] = "13"; i++; break;
                        case "E": letters[i] = "14"; i++; break;
                        case "F": letters[i] = "15"; i++; break;
                        case "G": letters[i] = "16"; i++; break;
                        case "H": letters[i] = "17"; i++; break;
                        case "I": letters[i] = "18"; i++; break;
                        case "J": letters[i] = "19"; i++; break;
                        case "K": letters[i] = "20"; i++; break;
                        case "L": letters[i] = "21"; i++; break;
                        case "M": letters[i] = "22"; i++; break;
                        case "N": letters[i] = "23"; i++; break;
                        case "O": letters[i] = "24"; i++; break;
                        case "P": letters[i] = "25"; i++; break;
                        case "Q": letters[i] = "26"; i++; break;
                        case "R": letters[i] = "27"; i++; break;
                        case "S": letters[i] = "28"; i++; break;
                        case "T": letters[i] = "29"; i++; break;
                        case "U": letters[i] = "30"; i++; break;
                        case "V": letters[i] = "31"; i++; break;
                        case "W": letters[i] = "32"; i++; break;
                        case "X": letters[i] = "33"; i++; break;
                        case "Y": letters[i] = "34"; i++; break;
                        case "Z": letters[i] = "35"; i++; break;
                    }
                }
                return letters[0] + letters[1];
            }
            else
            {
                return string.Empty;
            }
        }
        public string ValidateIban(string ibannummer)
        {
            if (ibannummer != null && ibannummer != "") //Logik um zu checken ob die Iban null oder leer ist
            {
                ibannummer = ibannummer.Replace(" ", ""); //FIX damit die Leerzeichen verschwinden
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
            else
            {
                return "Ungültiger Wert der IBAN";
            }
        }
    }
}