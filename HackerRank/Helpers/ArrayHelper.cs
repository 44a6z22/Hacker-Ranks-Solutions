using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Helpers
{
    public class ArrayHelper
    {
        public static int[] ConvertToInt(string a)
        {
            string[] strings = a.Split(' ');
            return Array.ConvertAll(strings, int.Parse).ToArray();
        }

        public static void Show (int [] a) {
            foreach (int u in a)
            {
                Console.Write(String.Format("{0} ", u));
            }
        }
    }
}
