using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dictionary;
namespace Dictionary
{
    public class Dictionary
    {
        public static implicit operator Dictionary(Dictionary<string, string> v)
        {
            throw new NotImplementedException();
        }
        public Dictionary<string, List<string>> CreateDictionary()
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> dictnew = new Dictionary<string, List<string>>();
            dict["Blume"] = new List<string> { "Blatt", "Stiel", "Grün", "Blüte" };
            dict["Baum"] = new List<string> { "Stamm", "Ast", "Blüte", "Grün", "Blatt" };
            dict["Pilz"] = new List<string> { "Hut", "Farbe", "Stiel" };

            foreach (var part in dict)
            {
                foreach (var val in part.Value)
                {
                    if (!dictnew.ContainsKey(val))
                    {
                        dictnew[val] = new List<string>();
                    }
                    dictnew[val].Add(part.Key);
                }
            }
            return dictnew;
        }
        public Dictionary<string, List<string>>  PrintNewDictionary(Dictionary<string, List<string>> dictnew)
        {
            foreach (var values in dictnew)
            {
                Console.WriteLine($"KEY: {values.Key}; VALUE: {string.Join(", ", values.Value)}");
            }
        return dictnew;
        }
    }
}

