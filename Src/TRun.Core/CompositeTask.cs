namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CompositeTask : ITask
    {
        private string name;
        private IList<ITask> tasks;

        public CompositeTask(string name, IEnumerable<ITask> tasks)
        {
            this.name = name;
            this.tasks = new List<ITask>(tasks);
        }

        public string Name { get { return this.name; } }

        public bool Run(Context context)
        {
            foreach (var task in this.tasks)
                if (!task.Run(context))
                    return false;

            return true;
        }
    }
}
