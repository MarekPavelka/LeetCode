using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitMSTest
{
    /* Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

    Note:

    The number of elements initialized in nums1 and nums2 are m and n respectively.
    You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
    Example:

    Input:
    nums1 = [1,2,3,0,0,0], m = 3
    nums2 = [2,5,6],       n = 3

    Output: [1,2,2,3,5,6] */

    [TestClass]
    public class MergeSortedArray
    {
        //not working
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var nums2LastNumberIdx = n - 1;
            var nums1EmptySlot = nums1.Length - 1;

            for (int nums1LastNumberIdx = m - 1; nums1LastNumberIdx >= 0; nums1LastNumberIdx--)
            {

                if (nums1[nums1LastNumberIdx] > nums2[nums2LastNumberIdx])
                    nums1[nums1EmptySlot--] = nums1[nums1LastNumberIdx];

                else if (nums1[nums1LastNumberIdx] == nums2[nums2LastNumberIdx])
                {
                    nums1[nums1EmptySlot--] = nums1[nums1LastNumberIdx];
                    nums1[nums1EmptySlot--] = nums2[nums2LastNumberIdx--];
                }
                else nums1[nums1EmptySlot--] = nums2[nums2LastNumberIdx--];
            }
        }

        public void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            var nums1ValueIdx = m - 1;
            var nums2ValueIdx = n - 1;
            var nums1LengthIdx = m + n - 1;
            while (nums1ValueIdx >= 0 && nums2ValueIdx >= 0)
            {
                if (nums1[nums1ValueIdx] > nums2[nums2ValueIdx])
                    nums1[nums1LengthIdx--] = nums1[nums1ValueIdx--];
                else
                    nums1[nums1LengthIdx--] = nums2[nums2ValueIdx--];
            }

            while (nums2ValueIdx >= 0)
                nums1[nums1LengthIdx--] = nums2[nums2ValueIdx--];
        }

        [TestMethod]
        public void WorksCorrectly()
        {
            //arrange
            var input1 = new int[] {1, 2, 3, 0, 0, 0};
            var input2 = new int[] {2, 5, 6};
            var output1 = new int[] {1, 2, 2, 3, 5, 6};

            //act
            //Merge2(input1, 3, input2, 3);
            Merge(input1, 3, input2, 3);

            //assert
            input1.Should().BeEquivalentTo(output1);
        }
    }
}