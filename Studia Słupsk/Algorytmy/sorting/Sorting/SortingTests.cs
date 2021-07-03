using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting
{
    [TestClass]
    public class SortingTests
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

        public bool CheckDataValidity(int[] data)
        {
            if (data.Length <= 1)
                return true;

            for (int i = 1; i < data.Length; ++i)
            {
                if (data[i] < data[i - 1])
                    return false;
            }
            return true;
        }

        //[TestMethod]
        //[DataRow(randomSortedFile)]
        //[DataRow(randomUnsortedFile)]
        //[DataRow(uniqueSortedFile)]
        //[DataRow(uniqueUnsortedFile)]
        //public void SelectionSort_Validity(string filename)
        //{
        //    var data = LoadDataFromFile(filename);
        //    var result = Sorting.SelectionSort(data);
        //    Assert.AreEqual(true, CheckDataValidity(result));
        //}

        [TestMethod]
        [DataRow(randomSortedFile)]
        [DataRow(randomUnsortedFile)]
        [DataRow(uniqueSortedFile)]
        [DataRow(uniqueUnsortedFile)]
        public void InsertionSort_Validity(string filename)
        {
            var data = LoadDataFromFile(filename);
            var result = Sorting.InsertionSort(data);
            Assert.AreEqual(true, CheckDataValidity(result));
        }

        [TestMethod]
        [DataRow(randomSortedFile)]
        [DataRow(randomUnsortedFile)]
        [DataRow(uniqueSortedFile)]
        [DataRow(uniqueUnsortedFile)]
        public void MergeSort_Validity(string filename)
        {
            var data = LoadDataFromFile(filename);
            var result = Sorting.MergeSort(data);
            Assert.AreEqual(true, CheckDataValidity(result));
        }

        //[TestMethod]
        //[DataRow(randomSortedFile)]
        //[DataRow(randomUnsortedFile)]
        //[DataRow(uniqueSortedFile)]
        //[DataRow(uniqueUnsortedFile)]
        //public void QuickSort_Validity(string filename)
        //{
        //    var data = LoadDataFromFile(filename);
        //    var result = Sorting.QuickSort(data);
        //    Assert.AreEqual(true, CheckDataValidity(result));
        //}

        [TestMethod]
        [DataRow(randomSortedFile)]
        [DataRow(randomUnsortedFile)]
        [DataRow(uniqueSortedFile)]
        [DataRow(uniqueUnsortedFile)]
        public void HeapSort_Validity(string filename)
        {
            var data = LoadDataFromFile(filename);
            var result = Sorting.HeapSort(data);
            Assert.AreEqual(true, CheckDataValidity(result));
        }
    }
}
