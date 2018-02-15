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
        public void IsUserInput_FindAndReplace1word_worldTouniverse()
        {
            FindAndReplace testFindAndReplace = new FindAndReplace("Hello world.", "world", "universe");
            string replacedWords = testFindAndReplace.ReplaceWords();
            Console.WriteLine(replacedWords);
            Assert.AreEqual("Hello universe.", replacedWords);
        }
    }
}
