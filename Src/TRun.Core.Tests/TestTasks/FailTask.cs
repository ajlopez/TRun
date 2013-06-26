namespace TRun.Core.Tests.TestTasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FailTask : ITask
    {
        private string name;
        private int counter;

        public FailTask(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        public int Counter { get { return this.counter; } }

        public bool Run(Context context)
        {
            this.counter++;
            return false;
        }
    }
}
