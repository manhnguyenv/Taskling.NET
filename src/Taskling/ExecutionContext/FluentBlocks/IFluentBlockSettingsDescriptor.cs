﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taskling.ExecutionContext.FluentBlocks
{
    public interface IFluentBlockSettingsDescriptor
    {
        IFluentBlockSettingsDescriptor ReprocessFailedTasks(TimeSpan detectionRange);
        IFluentBlockSettingsDescriptor ReprocessDeadTasks(TimeSpan detectionRange, TimeSpan treatAsDeadAfter);
        IFluentBlockSettingsDescriptor MaximumBlocksToGenerate(int maximumNumberOfBlocks);
    }
}
