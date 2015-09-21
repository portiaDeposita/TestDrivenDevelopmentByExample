using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestDrivenDevelopmentByExample.Util;

namespace TestDrivenDevelopmentByExampleTests.Util
{
    [TestFixture]
    public class DataUtilTest
    {
        private DataUtil _dataUtil;

        [SetUp]
        public void SetUpMethod()
        {
            _dataUtil = new DataUtil();
        }

        [Test]
        public void ThatTheResultReturnOne()
        {
            const string searchword = "the";
            const string paragraphtosearchfrom = "Sentence contains the in it";
            int returnedResult = _dataUtil.SearchNumberOfOccurances(searchword, paragraphtosearchfrom);
            Assert.AreEqual(1, returnedResult);
        }

        [Test]
        public void ThatTheSearchWordExistMoreThanOnceInASentence()
        {
            const string searchword = "like";
            const string sentence = "Portia and Carol dont like to " +
                                    "participate because they dont " +
                                    "like sharing their briliant ideas with the likes of stupid Chris";
            int numberOfWordOccurances = _dataUtil.SearchNumberOfOccurances(searchword, sentence);
            Assert.AreEqual(3, numberOfWordOccurances);
        }
        [Test]
        public void ThatTheSearchWordNotCaseSensitive()
        {
            const string searchword = "Like";
            const string sentence = "Portia and Carol dont like to " +
                                    "participate because they dont " +
                                    "like sharing their briliant ideas with the likes of stupid Chris";
            int numberOfWordOccurances = _dataUtil.SearchNumberOfOccurances(searchword, sentence);
            Assert.AreEqual(3, numberOfWordOccurances);
        }

        [Test]
        public void ThatNegativeNumberIsReturnedForANoneExistingWord()
        {
            const string searchword = "Lebo";
            const string sentence = "Portia and Carol dont like to " +
                                    "participate because they dont " +
                                    "like sharing their briliant ideas with the likes of stupid Chris";
            int numberOfWordOccurances = _dataUtil.SearchNumberOfOccurances(searchword, sentence);
            Assert.AreEqual(-1, numberOfWordOccurances);
        }
    }
}
