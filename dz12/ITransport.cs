﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz12
{
    public interface ITransport
    {
        string GetTransportType();
        decimal RentalCostPerMinute { get; }
    }
}
