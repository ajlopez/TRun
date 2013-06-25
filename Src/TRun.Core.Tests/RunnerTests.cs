namespace TRun.Core.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RunnerTests
    {
        [TestMethod]
        public void RunSimpleTaskWithName()
        {
            SimpleTask task = new SimpleTask("Simple");
            Runner runner = new Runner(new ITask[] { task });

            Assert.IsTrue(runner.Run("Simple"));
        }

        [TestMethod]
        public void RunWithoutNamedTask()
        {
            SimpleTask task = new SimpleTask("Simple");
            Runner runner = new Runner(new ITask[] { task });

            Assert.IsFalse(runner.Run("Complex"));
        }
    }
}
