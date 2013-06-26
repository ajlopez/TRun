namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Context
    {
        private Runner runner;

        public Context(Runner runner)
        {
            this.runner = runner;
        }

        public Runner Runner { get { return this.runner; } }
    }
}
