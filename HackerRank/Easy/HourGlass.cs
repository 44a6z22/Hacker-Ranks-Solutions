using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * The Problem : https://www.hackerrank.com/challenges/2d-array/problem?h_r=profile
 */

namespace HackerRank.Easy
{

    public class HourGlass
    {

        public int[][] _2DArray { get; set; }
        
        public HourGlass()
        {
            this._2DArray = new int[][]
            {
            new int[] {1,1,1,0,0,0},
            new int[] {0,1,0,0,0,0},
            new int[] {1,1,1,0,0,0},
            new int[] {0,0,2,4,4,0},
            new int[] {0,0,0,2,0,0},
            new int[] {0,0,1,2,4,0}
            };
        }
        public int GetIt()
        {
            List<int> number = new List<int>();            

            for (int  j = 1; j < this._2DArray.Length - 1; j++)
            {
                for (int i = 1; i <this._2DArray.Length - 1; i++)
                {
                    int res = 0;
                    res += (this._2DArray[j - 1][i - 1] + this._2DArray[j - 1][i] + this._2DArray[j - 1][i + 1]);

                    res += this._2DArray[j][i];

                    res += (this._2DArray[j + 1][i - 1] + this._2DArray[j + 1][i] + this._2DArray[j + 1][i + 1]);
                    
                    number.Add(res);
                }
            }

            return number.Max() ;
        }
           
    }
}
