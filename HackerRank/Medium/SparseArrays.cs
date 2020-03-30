using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * the Problem : https://www.hackerrank.com/challenges/sparse-arrays/problem
 */
namespace HackerRank.Medium
{
    public class SparseArrays
    {
        public string[] Strings { get; set;  }
        public string[] Queries { get; set; }

        public SparseArrays(string first, string secound )
        {
            this.Strings = first.Split(' ');
            this.Queries = secound.Split(' ');
        }

        public int[] Solve()
        {
            List<int> a = new List<int>();
            foreach (string i in this.Queries)
            {
                int counter = 0;
                foreach (string j in this.Strings) {
                    if(i == j) counter++;
                }
                a.Add(counter);
            }
            return a.ToArray();
        }
    }
}
