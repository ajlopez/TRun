namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TargetReader
    {
        public IList<Target> Read(string text)
        {
            return new List<Target>() { new Target(text, new ITask[] { }) };
        }
    }
}
