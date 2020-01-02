using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /* Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.


    In Pascal's triangle, each number is the sum of the two numbers directly above it.

    Example:

    Input: 5
    Output:
    [
        [1],
        [1,1],
        [1,2,1],
        [1,3,3,1],
        [1,4,6,4,1]
    ]*/

    [TestClass]
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> result = new List<IList<int>>();
            var row = new List<int>();

            for (int i = 1; i <= numRows; i++)
            {
                for (int j = row.Count - 1; j >= 1; j--)
                {
                    row[j] = row[j] + row[j - 1];
                }
                row.Add(1);
                result.Add(new List<int>(row));
            }
            return result;
        }

        [TestMethod]
        public void WorksCorrectly()
        {
        }
    }
}
