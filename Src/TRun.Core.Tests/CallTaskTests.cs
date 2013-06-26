namespace TRun.Core.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TRun.Core.Tests.TestTasks;

    [TestClass]
    public class CallTaskTests
    {
        [TestMethod]
        public void RunTaskByName()
        {
            CallTask task = new CallTask("Counter");
            CounterTask counter = new CounterTask("Counter");
            Runner runner = new Runner(new ITask[] { counter });
            Context context = new Context(runner);

            Assert.IsTrue(task.Run(context));

            Assert.AreEqual(1, counter.Counter);
        }
    }
}
