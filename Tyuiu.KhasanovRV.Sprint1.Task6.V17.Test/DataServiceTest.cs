using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint1.Task6.V17.Lib;

namespace Tyuiu.KhasanovRV.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            string x = "abba";
            var tf = ds.CheckPalindrome(x);
            Assert.AreEqual(true, tf);
        }
        
        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            string x = "123";
            var tf = ds.CheckPalindrome(x);
            Assert.AreEqual(false, tf);
        }
    }
}
