using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 *  The Problem  : https://www.hackerrank.com/challenges/picking-numbers/problem
 */

namespace HackerRank
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

        public int[] Optimized()
        {
            int[] ranks = new int[this.Scores.Length];

            int[] rs = new int[this.Alice.Length];

            List<int> newAlice = this.Alice.ToList();
            List<int> newScores = this.Scores.ToList();

            int a = newScores.BinarySearch(100);
            ranks[0] = 1;
            for (int i = 1; i < newScores.Count ; i++)
            {
                if (newScores[i] == newScores[i-1])
                {
                    ranks[i] = ranks[i-1];
                }
                else
                {
                    ranks[i] = ranks[i - 1] + 1;
                }
            }

            for (int i = 0; i< newAlice.Count; i++)
            {
                if ( newAlice[i] > newScores[0] )
                {
                    rs[i] = 1;
                }
                else if (newAlice[i] < newScores[newScores.Count - 1])
                {
                    int index = newScores.Count - 1;
                    rs[i] = ranks[index] +1;
                }
                else
                {
                    int index = getClosest(newScores.ToArray(), newAlice[i]);
                    rs[i] = ranks[index];
                }
            }

            return rs.ToArray();
        }
       
        private int getClosest(int[] ok , int number )
        {
            int nearest = Array.IndexOf(
                            ok,
                            ok.ToList().OrderBy(x => Math.Abs((long)x - number)).First()
                            );

            return nearest;
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
