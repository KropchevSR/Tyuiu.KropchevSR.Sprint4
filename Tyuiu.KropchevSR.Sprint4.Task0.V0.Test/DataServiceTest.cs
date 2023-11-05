using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint4.Task0.V0.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VailidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int Wait = 38;
            Assert.AreEqual(Wait, res);
        }
    }
}
