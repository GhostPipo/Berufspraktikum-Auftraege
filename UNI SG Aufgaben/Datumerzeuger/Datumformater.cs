using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateFormat;

namespace Datumerzeuger
{
    public class Datumformater
    {

        

        
        public static string FormatDatum(int day, int month, int year, string format)
        {
            
                switch (format)
                {
                    case "CH":
                        if (day < 10 && month < 10)
                        {
                        return $"CH-Format\n0{day}.0{month}.{year}";
                        }
                        else if (day >= 10 && month >= 10)
                        {
                        return $"CH-Format\n{day}.{month}.{year}";
                        }
                        else if (day < 10 && month >= 10)
                        {
                        return $"CH-Format\n0{day}.{month}.{year}";
                        }
                        else if (day >= 10 && month < 10)
                        {
                        return $"CH-Format\n{day}.0{month}.{year}";
                        }
                        break;

                    case "US":
                        if (day < 10 && month < 10)
                        {
                        return $"US-Format\n0{month}/0{day}/{year}";
                        }
                        else if (day >= 10 && month >= 10)
                        {
                        return $"US-Format\n{month}/{day}/{year}";
                        }
                        else if (day < 10 && month >= 10)
                        {
                        return $"US-Format\n{month}/0{day}/{year}";
                        }
                        else if (day >= 10 && month < 10)
                        {
                        return $"US-Format\n0{month}/{day}/{year}";
                        }
                        break;

                    case "ISO":
                        if (day < 10 && month < 10)
                        {
                        return $"ISO-Format\n{year}-0{month}-{day}";
                        }
                        else if (day >= 10 && month >= 10)
                        {
                        return $"ISO-Format\n{year}-{month}-{day}";
                        }
                        else if (day < 10 && month >= 10)
                        {
                        return $"ISO-Format\n0{year}-{month}-{day}";
                        }
                        else if (day >= 10 && month < 10)
                        {
                        return $"ISO-Format\n{year}-0{month}-{day}";
                        }
                    break;

                   

                }
            return "Fehler";
            }

        }
    }
