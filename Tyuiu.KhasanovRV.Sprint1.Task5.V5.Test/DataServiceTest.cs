using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KhasanovRV.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            var a = ds.Calculate(x);
            Assert.AreEqual(5, a);
        }
    }
}
