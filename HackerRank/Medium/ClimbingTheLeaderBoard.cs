using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.Alice = this.ToInt(alice).ToArray();
            this.Scores = this.ToInt(scores).ToArray();        
        }

        // works But times out one the 6, 7, 8, 9 th tests.
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

        private int[] ToInt(string value)
        {
            return Array.ConvertAll(
                    value.Split(' '),
                    int.Parse
                );
        }

    }
}
