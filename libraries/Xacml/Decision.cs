﻿using System;

namespace Xacml
{
    [Flags]
    public enum Decision
    {
        Permit = 1, 
        Deny = 2,
        Indeterminate = 4,
        NotApplicable = 0
    }
}