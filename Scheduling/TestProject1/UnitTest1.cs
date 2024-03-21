using Scheduling;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        PCB p1, p2, p3;
        [TestInitialize]
        public void Init()
        {
            p1 = new("A", 1);
            p2 = new("B", 2);
            p3 = new("C", 3);

        }
        [TestMethod]
        public void PCBToStringTest()
        {
            Assert.AreEqual("A(1)", p1.ToString());
            Assert.AreEqual("B(2)", p2.ToString());
            Assert.AreEqual("C(3)", p3.ToString());
        }
    }
}