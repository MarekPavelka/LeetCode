using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Green;

namespace Tests
{
    public class GreenTests
    {
        [Fact]
        public void LongestCommonPrefix2()
        {
            var input = new string[] { "ferko", "fer", "f" };

            var result = Green.LongestCommonPrefix2.longestCommonPrefix(input);
            result.Should().Be("f");
        }
    }
}
