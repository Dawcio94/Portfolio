using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringSearch
{
    [TestClass]
    public class StringSearchTests
    {
        const string houndFile = "doyle_hound.txt";
        const string houndPattern = "Hound";
        const string houndResultsFile = "doyle_hound_results.txt";

        const string dombeyFile = "dickens_dombey.txt";
        const string dombeyPattern = "woman";
        const string dombeyResultsFile = "dickens_dombey_results.txt";

        const string abFile = "AAAB.txt";
        const string abPattern = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAB";
        const string abResultsFile = "AAAB_results.txt";

        string ObtainTextFromFile(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                return sr.ReadToEnd();
            }
        }

        List<int> ObtainResults(string filename)
        {
            List<int> results = new List<int>();
            using (StreamReader sr = new StreamReader(filename))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    results.Add(int.Parse(line));
                }
            }
            return results;
        }

        void StoreResults(string filename, List<int> results)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var item in results)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }

        [TestMethod]
        [DataRow(houndFile, houndPattern, houndResultsFile)]
        [DataRow(dombeyFile, dombeyPattern, dombeyResultsFile)]
        [DataRow(abFile, abPattern, abResultsFile)]
        public void NaiveSearch_AllOccurences(string textFile, string pattern, string resultsFile)
        {
            string text = ObtainTextFromFile(textFile);
            var results = StringSearch.NaiveSearch(text, pattern);
            var expectedResults = ObtainResults(resultsFile);
            CollectionAssert.AreEqual(expectedResults, results);
        }

        [TestMethod]
        [DataRow(houndFile, "zxcvbnm,", houndResultsFile)]
        [DataRow(dombeyFile, "qzxqsdgwer", dombeyResultsFile)]
        [DataRow(abFile, "asdfasdf", abResultsFile)]
        public void NaiveSearch_NoOccurences(string textFile, string pattern, string resultsFile)
        {
            string text = ObtainTextFromFile(textFile);
            var results = StringSearch.NaiveSearch(text, pattern);
            var expectedResults = new List<int>();
            CollectionAssert.AreEqual(expectedResults, results);
        }

        [TestMethod]
        [DataRow(houndFile, houndPattern, houndResultsFile)]
        [DataRow(dombeyFile, dombeyPattern, dombeyResultsFile)]
        [DataRow(abFile, abPattern, abResultsFile)]
        public void KmpSearch_AllOccurences(string textFile, string pattern, string resultsFile)
        {
            string text = ObtainTextFromFile(textFile);
            var results = StringSearch.KmpSearch(text, pattern);
            var expectedResults = ObtainResults(resultsFile);
            CollectionAssert.AreEqual(expectedResults, results);
        }

        [TestMethod]
        [DataRow(houndFile, "zxcvbnm,", houndResultsFile)]
        [DataRow(dombeyFile, "qzxqsdgwer", dombeyResultsFile)]
        [DataRow(abFile, "asdfasdf", abResultsFile)]
        public void KmpSearch_NoOccurences(string textFile, string pattern, string resultsFile)
        {
            string text = ObtainTextFromFile(textFile);
            var results = StringSearch.KmpSearch(text, pattern);
            var expectedResults = new List<int>();
            CollectionAssert.AreEqual(expectedResults, results);
        }
    }
}
