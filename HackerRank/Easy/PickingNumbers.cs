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

    public class PickingNumbers
    {
        private List<int> Array { get; set; }
        
        public PickingNumbers(string array)
        {
            string[] strings = array.Split(' ');
            this.Array =  System.Array.ConvertAll(strings, int.Parse).ToList();
        }
        
        public int generate()
        {
            List<int> counts = new List<int>();
            List<int> list = new List<int>();
                
            this.Array.Sort();
            list.Add(this.Array[0]);
            int counter = 0;

            for (int e = 0; e < this.Array.Count; e++)
            {
                if ((this.Array[e] - list[0]) <= 1){
                    counter++;
                }else{
                    list[0] = this.Array[e];
                    counter = 1;
                }
                counts.Add(counter);
            }
            return counts.Max();
        }
    }
}
