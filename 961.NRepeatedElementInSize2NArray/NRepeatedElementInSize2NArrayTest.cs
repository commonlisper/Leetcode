using System;
using Xunit;

namespace _961.NRepeatedElementInSize2NArray
{
    public class NRepeatedElementInSize2NArrayTest
    {
        [Fact]
        public void Should_Raise_Exception_With_Null()
        {
            Assert.Throws(new ArgumentNullException().GetType(),
                () => new NRepeatedElementInSize2NArray().RepeatedNTimes(null));
        }

        [Fact]
        public void Should_Return_Zero_With_Empty_Array()
        {
            Assert.Equal(0, new NRepeatedElementInSize2NArray().RepeatedNTimes(new int[0]));
        }

        [Fact]
        public void Test_Case_1()
        {
            Assert.Equal(3, new NRepeatedElementInSize2NArray().RepeatedNTimes(new int[] { 1, 2, 3, 3 }));
        }

        [Fact]
        public void Test_Case_2()
        {
            Assert.Equal(2, new NRepeatedElementInSize2NArray().RepeatedNTimes(new int[] { 2, 1, 2, 5, 3, 2 }));
        }

        [Fact]
        public void Test_Case_3()
        {
            Assert.Equal(5, new NRepeatedElementInSize2NArray().RepeatedNTimes(new int[] { 5, 1, 5, 2, 5, 3, 5, 4 }));
        }
    }
}
