﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampler.Interfaces
{
    public interface IValidator
    {
        public bool IsValid(out bool skip, out bool replace);
    }
}
