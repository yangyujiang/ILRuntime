﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILRuntime.Runtime.Debugger
{
    public enum DebugMessageType
    {
        CSAttach,
        SCAttachResult,
        CSBindBreakpoint,
        SCBindBreakpointResult,
        SCModuleLoaded,
    }
}