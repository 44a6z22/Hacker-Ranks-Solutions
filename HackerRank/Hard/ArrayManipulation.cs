using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * The Problem :https://www.hackerrank.com/challenges/crush/problem
 */
namespace HackerRank.Hard
{
    public class ArrayManipulation
    {   
        public int[] Array { get; set; }
        public List<string []> L { get; set; }
        public ArrayManipulation(int arLength, string list)
        {
            this.Array = new int[arLength];
            this.L = new List<string[]>();
            for(int i = 0; i < arLength; i++)
            {
                this.Array[i] = 0; 
            }

            string[] s = list.Split(',');
            foreach (string se in s)
            {
                L.Add(se.Split(' '));
            } 
        }

        public long Solve()
        {
            //List<int> maxes = new List<int>();
            foreach (string [] str in this.L)
            {
                for (int i = int.Parse(str[0]) -1  ; i < int.Parse(str[1]) ; i++ ){
                    this.Array[i] += int.Parse(str[2]);        
                }
                //maxes.Add(this.Array.Max());
            }

            return (long) this.Array.Max();
        }
    }
}
