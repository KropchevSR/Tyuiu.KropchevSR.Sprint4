using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint4.Task2.V0.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int res = ds.Calculate(numsArray);
            int Wait = 21;
            Assert.AreEqual(Wait, res);
        }
    }
}
