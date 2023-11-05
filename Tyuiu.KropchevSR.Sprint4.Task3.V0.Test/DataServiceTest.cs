using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint4.Task3.V0.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task3.V0.Test
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
            int res = ds.Calculate(mas);
            int wait = 6;
            Assert.AreEqual(res, wait);
        }
    }
}
