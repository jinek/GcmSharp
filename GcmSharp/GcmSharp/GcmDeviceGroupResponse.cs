﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gcm.Net
{
    public class GcmDeviceGroupResponse : GcmResponse
    {
        public GcmDeviceGroupOptions Message { get; set; }
    }
}