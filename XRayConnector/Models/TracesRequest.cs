﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRayConnector
{
    public class TracesRequest
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string NextToken { get; set; }
    }
}
