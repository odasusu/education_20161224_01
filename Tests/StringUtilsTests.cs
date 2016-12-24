using NUnit.Framework;
using education_20161224_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace education_20161224_01.Tests
{
    [TestFixture()]
    public class StringUtilsTests
    {
        [TestCase("test", "st", 2, 2)]
        public void SubstringTest(string expected, string src, int startIndex, int length)
        {
            Assert.AreEqual(expected, StringUtils.Substring(src, startIndex, length));
        }
    }
}