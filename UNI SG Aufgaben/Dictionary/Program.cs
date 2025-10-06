namespace Dictionari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionaries obj1 = new Dictionaries();
            Dictionary<string, List<string>> dictnew = obj1.CreateDictionary();
            foreach (var i in dictnew)
            {
                Console.WriteLine($"KEY: {i.Key}; VALUE: {string.Join(", ", i.Value)}");
            }   
        }
    }
}
