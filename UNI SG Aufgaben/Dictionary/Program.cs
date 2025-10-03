using System.Runtime.InteropServices;
using Dictionary;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary obj1 = new Dictionary();
            Dictionary<string, List<string>> dictnew = obj1.CreateDictionary();
            obj1.PrintNewDictionary(dictnew);
        }
    }
}
