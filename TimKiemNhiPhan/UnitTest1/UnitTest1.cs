using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimKiemNhiPhan.Calulator;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        private Caculator cal = new Caculator();

        [TestMethod]
        public void AddTest()
        {
            Assert.IsTrue(cal.Add(1, 1) == 2);
            Assert.IsTrue(cal.Add(2, 2) == 4);
            //Assert.IsTrue(cal.Add(1,'a') == 2);
            Assert.AreEqual(20,cal.Add(10, 20));
        }
    }
}
