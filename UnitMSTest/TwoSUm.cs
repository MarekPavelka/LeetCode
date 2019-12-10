using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Linq;

namespace UnitMSTest
{
    /*1. Two Sum
 
    Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
 
    Example:
    Given nums = [2, 7, 11, 15], target = 9,
    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].*/

    [TestClass]
    public class TwoSum
    {
        public int[] GetIndexes(int[] nums, int target)
        {
            var controlArray = nums.Select(n => target - n).ToArray(); 
            var indexArray = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int i2 = i+1; i2 < controlArray.Length; i2++)
                {
                    if (controlArray[i] + controlArray[i2] == target)
                    {
                        indexArray[0] = i;
                        indexArray[1] = i2;
                        return indexArray;
                    }
                }
            }
            return indexArray;
        }

        [TestMethod]
        public void WorksCorrectly()
        {
            var numbers = new int[] {2, 7, 11, 15};
            int target = 9;

            var result = GetIndexes(numbers, target);

            result.Should().BeEquivalentTo(new int[] { 0, 1 });
        }

        [TestMethod]
        public void ReturnsFirstIndexesOfRepeatingNumbers()
        {
            var numbers = new int[] {2, 2};
            var numbers2 = new int[] {2, 5, 5, 11};

            int target = 4;
            int target2 = 10;

            var result = GetIndexes(numbers, target);
            var result2 = GetIndexes(numbers2, target2);

            result.Should().BeEquivalentTo(new int[] { 0, 1 });
            result2.Should().BeEquivalentTo(new int[] { 1, 2 });
        }
    }
}
