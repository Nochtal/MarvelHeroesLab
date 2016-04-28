using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarvelHeroesLabTests
{
    [TestClass]
    public class VillainTest
    {
        [TestMethod]
        [DeploymentItem(@"Marvel.db")]
        public void GetVillainsTest()
        {
            var villians = MarvelHeroesLabLibrary.Villain.GetAllVillians();
            Assert.IsTrue(villians.Count > 0);
        }

        [TestMethod]
        [DeploymentItem(@"Marvel.db")]
        public void GetHeroesTest()
        {
            var heroes = MarvelHeroesLabLibrary.Hero.GetAllHeroes();
            Assert.IsTrue(heroes.Count > 0);
        }
    }
}
