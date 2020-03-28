using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Helpers;

/**
 * The Problem : https://www.hackerrank.com/challenges/grading/submissions/code/143710903
 */

namespace HackerRank.Easy
{
    public class GradingStudents
    {  
        public int[] Grades { get; set; }

        public GradingStudents(string grades)
        {
            this.Grades = ArrayHelper.ConvertToInt(grades);
        }

        private int RoundedGrade(int grade)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((grade + i ) % 5 == 0)
                {
                    grade += i; 
                }
            }
            return grade;
        }

        public int[] Solve()
        {
            List<int> Gs = new List<int>();
            foreach (int grade in this.Grades)
            {
                bool isRoundable = false;
                int RoundGrade = grade; 
                if (grade >= 38)
                {
                    if (RoundedGrade(grade) % 5 == 0 )
                    {
                        isRoundable = true; 
                    }
                }
                if (isRoundable)
                {
                    RoundGrade = this.RoundedGrade(grade);
                }
                Gs.Add(RoundGrade);
            }
            return Gs.ToArray();
        }
        
    }
}
