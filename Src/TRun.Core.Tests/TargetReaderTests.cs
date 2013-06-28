namespace TRun.Core.Tests
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TargetReaderTests
    {
        [TestMethod]
        public void ReadSimpleTask()
        {
            TargetReader reader = new TargetReader();

            var result = reader.Read("target");

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("target", result[0].Name);
        }
    }
}
