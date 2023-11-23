using Microsoft.VisualStudio.TestTools.UnitTesting;
using YashProjectNewBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace YashProjectNewBL.Tests
{
    [TestClass()]
    public class GameHomePageTests
    {
        [TestMethod()]
        public void GameOverTest()
        {
            GameHomePage test = new GameHomePage(Game1: "gta", Game2: "nfs", 20, true);
            var result = test.GameOver();
            Assert.IsNotNull(result);   
        }
    }
}