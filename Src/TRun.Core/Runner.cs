namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Runner
    {
        private IList<ITarget> targets;
        private IList<ITarget> runnedtargets = new List<ITarget>();

        public Runner(IEnumerable<ITarget> targets)
        {
            this.targets = new List<ITarget>(targets);
        }

        public bool Run(string name)
        {
            var rtask = this.runnedtargets.FirstOrDefault(t => t.Name == name);

            if (rtask != null)
                return true;

            var task = this.targets.FirstOrDefault(t => t.Name == name);

            if (task != null)
            {
                var result = task.Run(null);

                if (result)
                    runnedtargets.Add(task);

                return result;
            }

            return false;
        }
    }
}
