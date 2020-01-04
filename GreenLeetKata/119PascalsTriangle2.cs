using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{

    /*Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.

    Note that the row index starts from 0.


    In Pascal's triangle, each number is the sum of the two numbers directly above it.

    Example:

    Input: 3
    Output: [1,3,3,1]*/

    [TestClass]
    public class PascalsTriangle2
    {
        public IList<int> GetRow(int rowIndex)
        {
            List<IList<int>> result = new List<IList<int>>();
            var row = new List<int>();

            for (int i = 0; i <= rowIndex; i++)
            {
                for (int j = row.Count - 1; j >= 1; j--)
                {
                    row[j] = row[j] + row[j - 1];
                }
                row.Add(1);
                result.Add(new List<int>(row));
            }
            return result[rowIndex];
        }


        // O(k) space 
        public List<int> GetRow2(int rowIndex)
        {
            List<int> row = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                row.Insert(0,1);
                for (int j = 1; j < row.Count - 1; j++)
                {
                    row[j]= row[j] + row[j + 1];
                }
            }
            return row;
        }

        [TestMethod]
        public void WorksCorrectly()
        {
        }
    }
}
