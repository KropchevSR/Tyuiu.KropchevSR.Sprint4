using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint4.Task1.V0.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 32;
            Assert.AreEqual(res, wait);
        }
    }
}
