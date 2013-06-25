namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Runner
    {
        private IList<ITask> tasks;
        private IList<ITask> rtasks = new List<ITask>();

        public Runner(IEnumerable<ITask> tasks)
        {
            this.tasks = new List<ITask>(tasks);
        }

        public bool Run(string name)
        {
            var rtask = this.rtasks.FirstOrDefault(t => t.Name == name);

            if (rtask != null)
                return true;

            var task = this.tasks.FirstOrDefault(t => t.Name == name);

            if (task != null)
            {
                var result = task.Run();

                if (result)
                    rtasks.Add(task);

                return result;
            }

            return false;
        }
    }
}
