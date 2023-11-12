using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint4.Task4.V12.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas = { { 5, 4, 9, 8, 5 },
                           { 4, 6, 6, 9, 9 },
                           { 9, 8, 4, 8, 8 },
                           { 6, 8, 6, 8, 9 },
                           { 9, 4, 6, 6, 7 } };
            int[,] res = ds.Calculate(mas);
            int[,] mas1 = { { 5, 1, 9, 1, 5 },
                            { 1, 1, 1, 9, 9 },
                            { 9, 1, 1, 1, 1 },
                            { 1, 1, 1, 1, 9 },
                            { 9, 1, 1, 1, 7 } };
            CollectionAssert.AreEqual(res, mas1);
        }
    }
}
