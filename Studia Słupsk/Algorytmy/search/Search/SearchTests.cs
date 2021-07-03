using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Search
{
    [TestClass]
    public class SearchTests
    {
        const string randomFile = "random_sorted.txt";
        const string uniqueFile = "unique_sorted.txt";

        public List<int> LoadDataFromFile(string filename)
        {
            List<int> data = new List<int>();
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    data.Add(int.Parse(sr.ReadLine()));
                }
            }
            return data;
        }

        [TestMethod]
        [DataRow(randomFile, 55558, 55443)]
        [DataRow(randomFile, 70000, 70073)]
        [DataRow(randomFile, 5000, 5045)]
        [DataRow(uniqueFile, 10, 10)]
        [DataRow(uniqueFile, 9999, 9999)]
        [DataRow(uniqueFile, 5000, 5000)]
        public void SearchLinear_FindIndexOfValue_ElementAvailable(string filename, int value, int expected)
        {
            var data = LoadDataFromFile(filename);
            var result = Search.SearchLinear(data, value);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(randomFile, -10)]
        [DataRow(randomFile, 123456)]
        [DataRow(uniqueFile, -10)]
        [DataRow(uniqueFile, 123456)]
        public void SearchLinear_FindIndexOfValue_ElementUnavailable(string filename, int value)
        {
            var data = LoadDataFromFile(filename);
            var result = Search.SearchLinear(data, value);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        [DataRow(randomFile, 55558, 55443)]
        [DataRow(randomFile, 70000, 70073)]
        [DataRow(randomFile, 5000, 5045)]   
        [DataRow(uniqueFile, 10, 10)]
        [DataRow(uniqueFile, 9999, 9999)]
        [DataRow(uniqueFile, 5000, 5000)]
        public void SearchBinary_FindIndexOfValue_ElementAvailable(string filename, int value, int expected)
        {
            var data = LoadDataFromFile(filename);
            var result = Search.SearchBinary(data, value);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(randomFile, -10)]
        [DataRow(randomFile, 123456)]
        [DataRow(uniqueFile, -10)]
        [DataRow(uniqueFile, 123456)]
        public void SearchBinary_FindIndexOfValue_ElementUnavailable(string filename, int value)
        {
            var data = LoadDataFromFile(filename);
            var result = Search.SearchBinary(data, value);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        [DataRow(randomFile, 123)]
        [DataRow(randomFile, 5432)]
        [DataRow(randomFile, 7777)]
        [DataRow(uniqueFile, 5678)]
        [DataRow(uniqueFile, 0)]
        [DataRow(uniqueFile, 9999)]
        public void Search_CompareMethods(string filename, int value)
        {
            var data = LoadDataFromFile(filename);
            var binaryResult = Search.SearchBinary(data, value);
            var linearResult = Search.SearchLinear(data, value);
            Assert.AreEqual(linearResult, binaryResult);
        }
    }
}
