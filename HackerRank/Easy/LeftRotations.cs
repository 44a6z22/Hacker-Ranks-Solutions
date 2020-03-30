using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Helpers;


/**
 * The Problem : https://www.hackerrank.com/challenges/array-left-rotation/problem
 */
namespace HackerRank.Easy
{
    public class LeftRotations
    {
        public int[] Array {get; set; }
        public LeftRotations(string array)
        {
            this.Array = ArrayHelper.ConvertToInt(array);
        }

        public int[] _Solve(int rotations)
        {
            for (int i = 0; i < rotations; i++)
            {
                int tmp = this.Array[0];
                for (int j = 1; j < this.Array.Length; j++)
                {
                    this.Array[j - 1] = this.Array[j];
                }
                this.Array[this.Array.Length - 1] = tmp;
            }
            return this.Array;
        }


        // new Approach 
        public int[] __Solve(int rotations)
        {
            List<int> newArray = new List<int>();
            for (int i = rotations; i < this.Array.Length; i++)
            {
                newArray.Add(this.Array[i]);
            }
            for (int i = 0; i < rotations; i++)
            {
                newArray.Add(this.Array[i]);
            }

            return newArray.ToArray();
        }
    }
}
