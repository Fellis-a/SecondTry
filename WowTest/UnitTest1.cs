using Microsoft.VisualStudio.TestTools.UnitTesting;
using WowVector;

namespace WowTest
{
    [TestClass]
    public class WowTest1
    {
        [TestMethod]
        public void VectorTest()
        {
            Vector firstVector = new Vector(2, 3, 2);
            Vector secondVector = new Vector(1, 2, 1);

            Vector resultVector = firstVector + secondVector;
            Vector expectedVector = new Vector(3, 5, 3);

            Assert.AreEqual(resultVector,expectedVector);
        }
    }
}
