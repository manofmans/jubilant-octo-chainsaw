using NUnit.Framework;

namespace NUnit.Tests
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
            var contr = new RestaurantModule.Controllers.HomeController();
            Assert.AreEqual(5, contr.testMethod(5));
            Assert.Pass();
        }
    }
}