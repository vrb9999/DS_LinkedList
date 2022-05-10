using Microsoft.VisualStudio.TestTools.UnitTesting;
using Add_Test;
using System;
using System.Collections.Generic;
using System.Text;

namespace Add_Test.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedList list = new LinkedList();
            list.Add(12);
            list.Add(30);
            list.Add(56);
            //Assert.IsTrue(list.Find(30));
        }
        [TestMethod]
        public void TestInsert()
        {
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.AddAfter(3, 40);
        }
    }
}