using System.Numerics;
using IBANPruefer;



string bbann = Calculations.CreateBban("23456", "200987439212");
BigInteger.Parse(bbann);
Console.WriteLine(bbann);
string pruefnummer = Calculations.CreatePruefzahl("23456", "200987439212", "121700");
BigInteger.Parse(pruefnummer);
Console.WriteLine(pruefnummer);
string IBAN = Calculations.CreateIban("CH", pruefnummer, bbann);
Console.WriteLine(IBAN);

string country = Calculations.GetCountry(null);
string IsIbanValid = Calculations.ValidateIban(null);
Console.WriteLine(IsIbanValid);


