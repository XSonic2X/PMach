using PMach;

namespace TestProjectMath
{
    [TestClass]
    public class UnitTestPMach
    {
        [TestMethod]
        public void TestAreaTriangle()
        {
            double p = Mathematics.AreaTriangle(10, 6, 8);
            Assert.AreEqual(24, p);
        }

        [TestMethod]
        public void TestAreaCircle() 
        {
            Assert.AreEqual(31, Math.Truncate(Mathematics.AreaCircle(3.142)));
        }

        [TestMethod]
        public void TestTriangleRectangular() 
        {
            Assert.AreEqual(true, Mathematics.TriangleRectangular(3,4,5));
        }
    }
}