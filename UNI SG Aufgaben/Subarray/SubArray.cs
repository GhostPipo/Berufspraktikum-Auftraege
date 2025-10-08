using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subarray;

namespace Subarray
{
    public class SubArray : OriginalArray
    {
        OriginalArray indexx = new OriginalArray();
        private int currentSum;
        private int maxSum;

        public int CurrentSum { get { return currentSum; } set { currentSum = value; } }
        public int MaxSum { get { return maxSum; } set { maxSum = value; } }

        public int getSum()
        {
            return 0;
        }
    }

}
