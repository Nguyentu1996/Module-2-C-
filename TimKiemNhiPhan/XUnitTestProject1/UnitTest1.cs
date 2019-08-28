using System;
using Xunit;
using TimKiemNhiPhan.Calulator;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        Caculator cal = new Caculator();
        [Fact]
        public void Test1()
        {
            Assert.Equal(10, cal.Add(5, 5));
        }
        [Theory]
        [InlineData(10,10,20)]
        [InlineData(5,5,10)]
        public void Addtheo(int a , int b , int c)
        {
            Assert.Equal(c, cal.Add(a, b));
        }
    }
}
