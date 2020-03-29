using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 *  The Problem  : https://www.hackerrank.com/challenges/magic-square-forming/problem
 */


namespace HackerRank.Medium
{
    public class MagicSquare
    {
        public int[][] Array { get; set; }

        private int[][][] PossibleCasesFor3X3Array { get; set; }

        public MagicSquare (int[][] array)
        {
            this.Array = array;

            this.PossibleCasesFor3X3Array = new int[][][]
            {
                new int [][] {new int [] {8, 1, 6}, new int [] {3, 5, 7}, new int [] {4, 9, 2}},
                new int [][] {new int [] {6, 1, 8}, new int [] {7, 5, 3}, new int [] {2, 9, 4}},
                new int [][] {new int [] {4, 9, 2}, new int [] {3, 5, 7}, new int [] {8, 1, 6}},
                new int [][] {new int [] {2, 9, 4}, new int [] {7, 5, 3}, new int [] {6, 1, 8}},
                new int [][] {new int [] {8, 3, 4}, new int [] {1, 5, 9}, new int [] {6, 7, 2}},
                new int [][] {new int [] {4, 3, 8}, new int [] {9, 5, 1}, new int [] {2, 7, 6}},
                new int [][] {new int [] {6, 7, 2}, new int [] {1, 5, 9}, new int [] {8, 3, 4}},
                new int [][] {new int [] {2, 7, 6}, new int [] {9, 5, 1}, new int [] {4, 3, 8}},
            };
        }
        // working on a General Solution.
        #region  Main
        public void Generate()
        {
            int changesCount    = 0,
                magicSum        = this.Sigma(this.Array.Length * this.Array.Length) / this.Array.Length,
                centerCellIndex = (int) Math.Floor( (double) this.Array.Length / 2),
                centerCellValue = magicSum / this.Array.Length;

            // change the center cell value to what ever value is calculated. 
            if (this.Array[centerCellIndex][centerCellIndex] != centerCellValue)
            {
                this.Array[centerCellIndex][centerCellIndex] = centerCellValue;
                changesCount = changesCount + 1;
            }
            
            //Get the dupplicate numbers. 
            List<int> dups = this.getDupplicates();

            for (int x = 0; x < this.Array.Length; x++)
            {
                for (int z = 0; z < this.Array.Length; z++)
                {
                    for (int i = 1; i < dups.Count; i++)
                    {
                        if ( i != this.Array[x][z])
                        {
                            this.Array[x][z] = i;
                        }
                    }
                
                }
            }
            

        }
        #endregion

        #region Privates 
        private int Sigma(int number)
        {
            int res = 0;
            for (int i = 1; i <= number; i++)
            {
                res += i;
            }
            return res;
        }

        private List<int> getDupplicates()
        {
            List<int> tmp = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (int[] row in this.Array)
            {
                foreach (int cellnumber in row)
                {
                    tmp[cellnumber]++;
                }
            }
            return tmp;
        }
        #endregion

        #region Helpers

        public void ShowDuplicates(List<int> dups)
        {
            for (int i = 1; i < dups.Count; i++)
            {
                Console.WriteLine(
                    String.Format("{0} => {1}", i, dups[i])
                    );
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            foreach (int[] row in this.Array)
            {
                foreach (int cellValue in row)
                {
                    Console.Write(
                           String.Format("{0} ", cellValue)
                        );
                }
                Console.WriteLine("");
            }
        }
        #endregion

        // 3x3 Solution
        #region A 3x3 Magic Square Sollution...
        
        public int _3X3MAgicSquareMinMoves()
        {
            List<int> allChanges = new List<int>();
           
            foreach (int[][] _3X3Array in this.PossibleCasesFor3X3Array ){

                int changes = 0;
                for (int i = 0; i < _3X3Array.Length; i++) { 
                    for (int j = 0; j < _3X3Array.Length; j++) {
                        List<int> e = new List<int>();
                        if (this.Array[i][j] != _3X3Array[i][j] ) {
                            e.Add(this.Array[i][j]);
                            e.Add(_3X3Array[i][j]);
                            changes += e.Max() - e.Min();
                        }
                    }
                }
                allChanges.Add(changes);
            }

            return allChanges.Min();
        }
        #endregion

    }
}
