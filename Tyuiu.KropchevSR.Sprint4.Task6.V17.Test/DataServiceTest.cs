using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint4.Task6.V17.Lib;

namespace Tyuiu.KropchevSR.Sprint4.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string[] res = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int wait = 2;
            Assert.AreEqual(ds.Calculate(res), wait);
        }
    }
}
