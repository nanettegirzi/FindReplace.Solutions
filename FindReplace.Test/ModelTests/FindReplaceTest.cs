using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using FindReplace.Models;

namespace FindReplace.Tests
{
    [TestClass]
    public class FindAndReplaceTest
    {
        [TestMethod]
        public void IsUserInput_FindAndReplace_worldTouniverse()
        {
            FindAndReplace testFindAndReplace = new FindAndReplace("world");
            Assert.AreEqual("universe", testFindAndReplace.ReplaceWords());
        }
    }
}
