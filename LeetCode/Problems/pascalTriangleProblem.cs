using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Problems
{
    public static class pascalTriangleProblem
    {
        public static IList<IList<int>> implementation(int numRows)
        {
            var result = new List<IList<int>>();

            if (numRows == 0)
                return result;
                        
            var previousRow = new List<int>();
            previousRow.Add(1);
            result.Add(previousRow);

            for (int i = 1; i < numRows; i++)
            {
                var currentRow = new List<int>();                
                int previous = 0;
                foreach (int val in previousRow)
                {
                    currentRow.Add(previous + val);
                    previous = val;
                }                
                currentRow.Add(1);

                result.Add(currentRow);
                previousRow = currentRow;
            }
            return result;
        }

    }
}
