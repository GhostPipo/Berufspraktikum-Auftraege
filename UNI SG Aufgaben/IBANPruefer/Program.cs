using System.Numerics;
using IBANPruefer;

string bbann = Calculations.CreateBBAN("23456", "200987439212");
BigInteger.Parse(bbann);
Console.WriteLine(bbann);
string pruefnummer = Calculations.CreatePruefzahl("23456", "200987439212", "121700");
BigInteger.Parse(pruefnummer);
Console.WriteLine(pruefnummer);
string IBAN = Calculations.CreateIban("CH", pruefnummer, bbann);
Console.WriteLine(IBAN);
string country = Calculations.GetCountry("CH4212345200297680912");
string IsIbanValid = Calculations.ValidateIban("CH4212345200297680912");
Console.WriteLine(IsIbanValid);


