﻿using System;
using System.Collections.Generic;

namespace ShootR
{
    public class Payload
    {
        public Payload()
        {
            Ships = new List<object>();
            Bullets = new List<object>();
        }

        public List<object> Ships { get; set; }
        public int LeaderboardPosition { get; set; }
        public List<object> Bullets { get; set; }
        public int ShipsInWorld { get; set; }
        public int BulletsInWorld { get; set; }

        public int Experience { get; set; }
        public int ExperienceToNextLevel { get; set; }

        public string Notification { get; set; }
        public long LastCommandProcessed { get; set; }
        public long ID { get; set; }
    }
}