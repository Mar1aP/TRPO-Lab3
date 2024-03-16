using TRPO_Lab3.Lib;

namespace TRPO_Lab3.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double actual = SphereLayer.FindVolume(15, 30, 5);
            double expected = 8901.179;
            Assert.Greater(0.001, Math.Abs(actual - expected));
        }

        [Test]
        public void Test2()
        {
            double actual = SphereLayer.FindVolume(5, 10, 5);
            double expected = 1047.198;
            Assert.Greater(0.001, Math.Abs(actual - expected));
        }

        [Test]
        public void Test3()
        {
            double actual = SphereLayer.FindVolume(20, 10, 10);
            double expected = 8377.580;
            Assert.Greater(0.001, Math.Abs(actual - expected));
        }

        [Test]
        public void Test4()
        {
            Assert.Throws(typeof(ArgumentException), () => { SphereLayer.FindVolume(-20, 10, 10); });
            Assert.Throws(typeof(ArgumentException), () => { SphereLayer.FindVolume(20, -10, 10); });
            Assert.Throws(typeof(ArgumentException), () => { SphereLayer.FindVolume(20, 10, -10); });
        }
    }
}