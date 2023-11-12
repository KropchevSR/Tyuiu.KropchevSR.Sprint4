using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint4.Task5.V5.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas = { { 0,0, 0, 0, 0 },
                           { -2, -2, -2, -2, -2 },
                           { 1, 1, 1, 1, 1 },
                           { 2, 2, 2, 2, 2 },
                           { -4, -4, -6, -6, -7 } };
            int res = ds.Calculate(mas);
            int wait = 15;
            Assert.AreEqual(res, wait);
        }
    }
}
