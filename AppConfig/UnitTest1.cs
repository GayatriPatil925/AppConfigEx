using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

namespace AppConfig
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string name = ConfigurationManager.AppSettings["name"];
            Console.WriteLine(name);
        }
    }
}
