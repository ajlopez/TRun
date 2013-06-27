namespace TRun.Core.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TRun.Core.Tests.TestTasks;

    [TestClass]
    public class CompositeTaskTests
    {
        [TestMethod]
        public void RunTwoTasks()
        {
            CounterTask task1 = new CounterTask();
            CounterTask task2 = new CounterTask();

            CompositeTask task = new CompositeTask(new ITask[] { task1, task2 });

            Assert.IsTrue(task.Run(null));
            Assert.AreEqual(1, task1.Counter);
            Assert.AreEqual(1, task2.Counter);
        }

        [TestMethod]
        public void RunNoTasks()
        {
            CompositeTask task = new CompositeTask(new ITask[] { });

            Assert.IsTrue(task.Run(null));
        }

        [TestMethod]
        public void RunTwoTasksOfThree()
        {
            CounterTask task1 = new CounterTask();
            FailTask fail = new FailTask();
            CounterTask task2 = new CounterTask();

            CompositeTask task = new CompositeTask(new ITask[] { task1, fail, task2 });

            Assert.IsFalse(task.Run(null));
            Assert.AreEqual(1, task1.Counter);
            Assert.AreEqual(1, fail.Counter);
            Assert.AreEqual(0, task2.Counter);
        }
    }
}
