namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CallTargetTask : ITask
    {
        private string taskname;

        public CallTargetTask(string taskname)
        {
            this.taskname = taskname;
        }

        public bool Run(Context context)
        {
            return context.Runner.Run(this.taskname);
        }
    }
}
