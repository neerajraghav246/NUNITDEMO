using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExample.Tests
{
    [TestFixture]
    public class SentenceParserTest
    {
        SentenceParser sentenceParser;

        [SetUp]
        public void SetupTest()
        {
            sentenceParser = new SentenceParser();
        }

        [Test]
        public void TestGetNoofWordsInString()
        {
            string sentence = "coding is fun";
            // this contains three words, we expect our code to return 3
            var noofWords = sentenceParser.GetNoofWordsInString(sentence);
            Assert.AreEqual(3, noofWords);
        }

        [TearDown]
        public void TearDownTest()
        {
            sentenceParser = null;
        }
    }
}
