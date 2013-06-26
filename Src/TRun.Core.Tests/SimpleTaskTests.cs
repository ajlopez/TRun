namespace TRun.Core.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SimpleTaskTests
    {
        [TestMethod]
        public void RunSimpleTask()
        {
            SimpleTask task = new SimpleTask("Simple");

            Assert.AreEqual("Simple", task.Name);
            Assert.IsTrue(task.Run(null));
        }
    }
}
