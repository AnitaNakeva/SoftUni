﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class SoulMaster:DarkWizard
    {
        public SoulMaster(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
        public string Username { get; set; }
        public int Level { get; set; }
    }
}
