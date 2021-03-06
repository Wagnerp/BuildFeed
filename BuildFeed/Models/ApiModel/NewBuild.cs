﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildFeed.Models.ApiModel
{
    public class NewBuild
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public NewBuildObject[] NewBuilds { get; set; }
    }

    public class NewBuildObject
    {
        public byte MajorVersion { get; set; }
        public byte MinorVersion { get; set; }
        public ushort Number { get; set; }
        public ushort? Revision { get; set; }
        public string Lab { get; set; }
        public DateTime? BuildTime { get; set; }
        public LevelOfFlight FlightLevel { get; set; }
    }
}