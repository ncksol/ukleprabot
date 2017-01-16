﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UKLepraBot
{
    public class ChatSettings
    {
        public Dictionary<string, Tuple<int, int>> DelaySettings { get; set; } = new Dictionary<string, Tuple<int, int>>();
        public Dictionary<string, int> Delay { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, bool> State { get; set; } = new Dictionary<string, bool>();
    }
}