using DataAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DBContextTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataBase DB = new DataBase();
            int initCount = DB.GetCount();
            DB.AddNew("Pupkino", DateTime.Now.AddHours(-2), "Anykeyevka", DateTime.Now.AddHours(2));
            Assert.AreEqual(initCount + 1, DB.GetCount());
        }
    }
}
