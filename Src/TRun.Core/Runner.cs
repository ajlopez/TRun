namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Runner
    {
        private IList<ITask> tasks;

        public Runner(IEnumerable<ITask> tasks)
        {
            this.tasks = new List<ITask>(tasks);
        }

        public bool Run(string name)
        {
            return this.tasks.First().Run();
        }
    }
}
