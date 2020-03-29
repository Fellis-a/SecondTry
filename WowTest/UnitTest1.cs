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
        [TestMethod]
        public void VectorMinusTest()
        {
            Vector firstVector = new Vector(2, 3, 2);
            Vector secondVector = new Vector(1, 2, 1);

            Vector resultVector = firstVector - secondVector;
            Vector expectedVector = new Vector(1, 1, 1);

            Assert.AreEqual(resultVector, expectedVector);
        }

        [TestMethod]
        public void VectorMultScalarTest()
        {
            Vector firstVector = new Vector(2, 3, 2);
            Vector secondVector = new Vector(1, 2, 1);

            var resultVector = Vector.scalar(firstVector,secondVector);
            

            Assert.AreEqual(resultVector, 10);
        }

        [TestMethod]
        public void VectorMultVectorTest()
        {
            Vector firstVector = new Vector(2, 3, 2);
            Vector secondVector = new Vector(1, 2, 1);

            Vector resultVector = firstVector * secondVector;
            Vector expectedVector = new Vector(-1, 0, 1);

            Assert.AreEqual(resultVector, expectedVector);
        }
        [TestMethod]
        public void VectorLengthTest()
        {
            Vector firstVector = new Vector(1, 2, 2);

            var resultVector = Vector.lengthV(firstVector);
           

            Assert.AreEqual(resultVector, 3);
        }
    }
}
