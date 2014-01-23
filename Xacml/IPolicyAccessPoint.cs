﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xacml
{
    public interface IPolicyAccessPoint
    {
        IEnumerable<PolicyType> GetPoliciesThatTargetAttributes(IEnumerable<AttributesType> attributes);
    }
}
