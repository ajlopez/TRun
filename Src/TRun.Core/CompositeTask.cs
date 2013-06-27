namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CompositeTask : ITask
    {
        private IList<ITask> tasks;

        public CompositeTask(IEnumerable<ITask> tasks)
        {
            this.tasks = new List<ITask>(tasks);
        }

        public bool Run(Context context)
        {
            foreach (var task in this.tasks)
                if (!task.Run(context))
                    return false;

            return true;
        }
    }
}
