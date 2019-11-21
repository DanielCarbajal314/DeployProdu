using DevOpsData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DataTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ThereIsAnApple()
        {
            Assert.IsTrue(new ProductRepository().GetAll().Any(x => x.Name.Equals("Apple")));
        }
        [TestMethod]
        public void ThereIsAnOrange()
        {
            Assert.IsTrue(new ProductRepository().GetAll().Any(x => x.Name.Equals("Orange")));
        }
    }
}
