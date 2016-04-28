using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarvelHeroesLabTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DeploymentItem("Villians.db")]
        public void TestMethod1()
        {
            var villians = MarvelHeroesLabLibrary.Villian.GetAllVillians();
            Assert.IsTrue(villians.Count > 0);
        }
    }
}
