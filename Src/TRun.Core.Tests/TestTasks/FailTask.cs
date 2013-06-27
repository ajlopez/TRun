namespace TRun.Core.Tests.TestTasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FailTask : ITask
    {
        private int counter;

        public int Counter { get { return this.counter; } }

        public bool Run(Context context)
        {
            this.counter++;
            return false;
        }
    }
}
