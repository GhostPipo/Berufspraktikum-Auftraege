namespace Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OriginalArray digitcount = new OriginalArray();
            int i = digitcount.GetCountString(100, -100, 1000);
            Console.WriteLine(i);
    }
    }
}
