using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhasanovRV.Sprint1.Task1.V1.Lib;

namespace Tyuiu.KhasanovRV.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0, x = 3.0, y = 1.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(7, res);
        }
    }
}
