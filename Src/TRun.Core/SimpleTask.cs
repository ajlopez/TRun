namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SimpleTask : ITask
    {
        private string name;

        public SimpleTask(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        public bool Run()
        {
            return true;
        }
    }
}
