using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Helpers;

/**
 *  The Problem  : https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem?isFullScreen=false
 */

namespace HackerRank.Medium
{
    public class ClimbingTheLeaderBoard
    {
        private int[] Scores { get; set; }
        private int[] Alice { get; set; }
        public int Count
        {
            get
            {
                return this.Scores.Length; 
            }
        }
        
        public ClimbingTheLeaderBoard(string scores, string alice)
        {
            this.Alice = ArrayHelper.ConvertToInt(alice);
            this.Scores = ArrayHelper.ConvertToInt(scores);
        }

        // works But timesOut on the 6th, 7th, 8th and the 9th test.
        public int[] Solve()
        {
            List<int> ranks = new List<int>();
            this.Scores = this.Scores.Distinct().ToArray();
            foreach (int s in this.Alice)
            {
                int counter = 0;
                
                if ( this.Scores.Contains(s))
                {
                    List<int> l = new List<int>();
                    counter = Array.IndexOf(this.Scores, s);
                    l = this.Scores.ToList();
                    l.Remove(s);
                    this.Scores = l.ToArray();
                    l.Clear();
                }
                else{
                    foreach (int a in this.Scores)
                    {
                        if (a > s)
                        {
                            counter++;
                        }
                    }

                }
                ranks.Add(counter + 1);

            }

            return ranks.ToArray();
        }
        
    }
}
