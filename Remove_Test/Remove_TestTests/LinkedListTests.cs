using Microsoft.VisualStudio.TestTools.UnitTesting;
using Remove_Test;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remove_Test.Tests
{
    [TestClass]
    public class UnitTest1
    {      
        [TestMethod]
        public void TestSize()
        {
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(30);
            list.Append(40);
            list.Append(70);
            list.delete(40);
            Assert.AreEqual(3, list.Size());
        }
    }
}