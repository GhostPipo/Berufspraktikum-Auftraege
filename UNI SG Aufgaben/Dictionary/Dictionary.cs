namespace Dictionari
{
    public class Dictionaries
    {
        public Dictionary<string, List<string>> CreateDictionary()
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> dictnew = new Dictionary<string, List<string>>();
            dict["Döner"] = new List<string> { "Brot", "Salat", "Fleisch", "Zwiebel" };
            dict["Pizza"] = new List<string> { "Teig", "Fleisch", "Käse", "Sosse" };
            dict["Lasagne"] = new List<string> { "Sosse", "Teig", "Fleisch", "zwiebel" };
            dict["Brot"] = new List<string> { "Teig", "Salz", "Milch" };
            foreach (var part in dict)
            {
                foreach (var val in part.Value)
                {
                    if (!dictnew.ContainsKey(val.ToUpper()))
                    {                       
                        dictnew[val.ToUpper()] = new List<string>();
                    }
                    dictnew[val.ToUpper()].Add(part.Key);
                }
            }
            return dictnew;
        }
    }
}

