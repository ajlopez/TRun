namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Target : CompositeTask, ITarget
    {
        private string name;

        public Target(string name, IEnumerable<ITask> tasks)
            : base(tasks)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }
    }
}
