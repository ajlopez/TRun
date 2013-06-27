namespace TRun.Core.Tests.TestTasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SimpleTask : ITask
    {
        public bool Run(Context context)
        {
            return true;
        }
    }
}
