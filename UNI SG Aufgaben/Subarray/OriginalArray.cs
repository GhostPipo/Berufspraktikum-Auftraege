using System.Globalization;

namespace Subarray
{
    public class OriginalArray
    {
        public int GetCountString(int count, int min, int max)
        {
            Random random = new Random();
            string stringchain = string.Join(", ",Enumerable.Range(0, count).Select(_ => random.Next(min, max + 1)));
            int digitCount = stringchain.Length;
            return digitCount;
        }
    }
}
