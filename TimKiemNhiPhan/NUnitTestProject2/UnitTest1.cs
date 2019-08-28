using NUnit.Framework;
using TimKiemNhiPhan.Calulator;

namespace Tests
{

    public class Tests
    {
        Caculator cal;
        [SetUp]
        public void Setup()
        {
            cal = new Caculator();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, cal.Add(1, 1));
        }
        [TestCase(2, 2, 4)]
        [TestCase(4, 2, 6)]
        [TestCase(1, 5, 6)]
        public void Test2(int a, int b, int c)
        {
            Assert.IsTrue(cal.Add(a, b) == c);
        }
    
    }
}