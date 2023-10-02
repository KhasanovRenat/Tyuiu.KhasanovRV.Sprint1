using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhasanovRV.Sprint1.Task1.V25.Lib;

namespace Tyuiu.KhasanovRV.Sprint1.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0, y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
