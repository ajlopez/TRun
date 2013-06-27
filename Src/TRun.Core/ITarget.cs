namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface ITarget : ITask
    {
        string Name { get; }
    }
}
