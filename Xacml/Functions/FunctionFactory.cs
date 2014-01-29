﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xacml.Functions
{
    public class FunctionFactory
    {
        private IDependencyResolver resolver;
        
        public FunctionFactory(IDependencyResolver resolver)
        {
            this.resolver = resolver;
        }

        public IFunction Create(string name)
        {
            return resolver.GetService<IFunction>(name);
        }
    }
}