using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Helpers;
namespace HackerRank.Easy
{
    public class CompareTheTriplets
    {
        public int[] FirstT {get; set; }
        public int[] SecoundT { get; set; }

        public CompareTheTriplets(string a, string b)
        {
            FirstT = ArrayHelper.ConvertToInt(a);
            SecoundT = ArrayHelper.ConvertToInt(b);
        }
  
        public int[] Solve()
        {

            int[] scores = new int[] { 0, 0 };

            if (this.FirstT.Length == this.SecoundT.Length)
            {
                for (int i  = 0; i < this.FirstT.Length; i++)
                {
                    if (this.FirstT[i] > this.SecoundT[i])
                    {
                        scores[0]++;
                    }
                    else if (this.FirstT[i] < this.SecoundT[i])
                    {
                        scores[1]++;
                    }
                }
            }
            return scores;
        }
    }
}
