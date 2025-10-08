using System.Numerics;
using IBANPruefer;

Calculations BBAN = new Calculations();
Calculations Proofnumber = new Calculations();
Calculations IBAN = new Calculations();
Calculations Country = new Calculations();
Calculations IsValid = new Calculations();
string expectedIBAN = "CH3580808006438396881";

string countrycode = Country.GetCountry(expectedIBAN);
string bban = BBAN.CreateBBAN("23456", "200987439212");
Console.WriteLine(bban);
string proofnumber = Proofnumber.CreatePruefzahl(bban, countrycode);
Console.WriteLine(proofnumber);
string iban = IBAN.CreateIban("CH", proofnumber, bban);
string country = Country.GetCountry(iban);
Console.WriteLine(country);
bool isValid = IsValid.ValidateIban(iban);
Console.WriteLine(isValid);


