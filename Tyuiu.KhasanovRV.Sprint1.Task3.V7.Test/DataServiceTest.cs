using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint1.Task3.V7.Lib;

namespace Tyuiu.KhasanovRV.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidEspression()
        {
            DataService ds = new DataService();
            double a = 100;
            var x = ds.VerstsToKilometers(a);
            Assert.AreEqual(106,68, x);
        }
    }
}
