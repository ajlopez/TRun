namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CallTask : ITask
    {
        private string taskname;

        public CallTask(string taskname)
        {
            this.taskname = taskname;
        }

        public string Name { get { return null; } }

        public bool Run(Context context)
        {
            return context.Runner.Run(this.taskname);
        }
    }
}
