namespace TRun.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface ITask
    {
        string Name { get; }

        bool Run();
    }
}
