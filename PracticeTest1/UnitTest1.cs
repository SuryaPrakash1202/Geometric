using PracticeBL;
namespace PracticeTest1
{
    [TestClass]
    public class UnitTest1
    {
        Circle obj1 = new Circle(2.4, "white", true);
        [TestMethod]
        public void TestMethod1()
        {
            double expected = 18.086399999999998;
            double actual=obj1.Area();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double expected = 4.8;
            double actual = obj1.Diameter();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double expected = 15.072;
            double actual = obj1.Perimeter();
            Assert.AreEqual(expected, actual);
        }
        Rectangle obj2 = new Rectangle(4, 5, "black", true);
        [TestMethod]
        public void TestMethod4() {
            double expected = 20;
            double actual = obj2.Area();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5() {
            double expected = 4.5;
            double actual = obj2.Perimeter();   
            Assert.AreEqual(expected, actual);
        }
    }
}