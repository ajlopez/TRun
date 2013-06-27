namespace TRun.Core.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TRun.Core.Tests.TestTasks;

    [TestClass]
    public class RunnerTests
    {
        [TestMethod]
        public void RunSimpleTaskWithName()
        {
            Target target = new Target("Simple", new ITask[] { });
            Runner runner = new Runner(new ITarget[] { target });

            Assert.IsTrue(runner.Run("Simple"));
        }

        [TestMethod]
        public void RunWithoutNamedTask()
        {
            Target target = new Target("Simple", new ITask[] { });
            Runner runner = new Runner(new ITarget[] { target });

            Assert.IsFalse(runner.Run("Complex"));
        }

        [TestMethod]
        public void RunCounterTask()
        {
            CounterTask task = new CounterTask();
            Target target = new Target("Counter", new ITask[] { task });
            Runner runner = new Runner(new ITarget[] { target });

            Assert.IsTrue(runner.Run("Counter"));
            Assert.AreEqual(1, task.Counter);
        }

        [TestMethod]
        public void RunCounterTaskOnce()
        {
            CounterTask task = new CounterTask();
            Target target = new Target("Counter", new ITask[] { task });
            Runner runner = new Runner(new ITarget[] { target });

            Assert.IsTrue(runner.Run("Counter"));
            Assert.IsTrue(runner.Run("Counter"));
            Assert.AreEqual(1, task.Counter);
        }
    }
}
