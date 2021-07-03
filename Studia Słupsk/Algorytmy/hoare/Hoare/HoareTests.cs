using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hoare
{
    [TestClass]
    public class HoareTests
    {
        const string randomSortedFile = "random_sorted.txt";
        const string randomUnsortedFile = "random_unsorted.txt";
        const string uniqueSortedFile = "unique_sorted.txt";
        const string uniqueUnsortedFile = "unique_unsorted.txt";

        public int[] LoadDataFromFile(string filename)
        {
            List<int> data = new List<int>();
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    data.Add(int.Parse(sr.ReadLine()));
                }
            }
            return data.ToArray();
        }

        [TestMethod]
        [DataRow(randomSortedFile, 5, 10)]
        [DataRow(randomSortedFile, 56789, 56926)]
        [DataRow(randomUnsortedFile, 5, 10)]
        [DataRow(randomUnsortedFile, 56789, 56926)]
        [DataRow(uniqueSortedFile, 5, 5)]
        [DataRow(uniqueSortedFile, 56789, 56789)]
        [DataRow(uniqueUnsortedFile, 5, 5)]
        [DataRow(uniqueUnsortedFile, 56789, 56789)]
        public void QuickSelect_Valid(string filename, int value, int expected)
        {
            var data = LoadDataFromFile(filename);
            var result = HoareAlgorithm.QuickSelect(data, value);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(randomSortedFile, -10)]
        [DataRow(randomSortedFile, 123456)]
        [DataRow(randomUnsortedFile, -10)]
        [DataRow(randomUnsortedFile, 123456)]
        [DataRow(uniqueSortedFile, -10)]
        [DataRow(uniqueSortedFile, 123456)]
        [DataRow(uniqueUnsortedFile, -10)]
        [DataRow(uniqueUnsortedFile, 123456)]
        public void QuickSelect_Invalid(string filename, int value)
        {
            var data = LoadDataFromFile(filename);
            var result = HoareAlgorithm.QuickSelect(data, value);
            Assert.AreEqual(-1, result);
        }
    }
}
