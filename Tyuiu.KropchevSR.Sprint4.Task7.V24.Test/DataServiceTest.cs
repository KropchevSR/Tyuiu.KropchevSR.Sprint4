using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint4.Task7.V24.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string res = "651827384219648";
            int wait = 1179648;
            Assert.AreEqual(ds.Calculate(5,3,res), wait);
        }
    }
}
