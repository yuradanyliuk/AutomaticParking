﻿namespace AutomaticParking.Agents.Data
{
    public static class ParkingAgentRecordKey
    {
        public const string TargetReach = Header.Agent + nameof(TargetReach);
        public const string DistanceToTarget = Header.Agent + nameof(DistanceToTarget);
        public const string AngleToTarget = Header.Agent + nameof(AngleToTarget);

        public static class Header
        {
            private const string Separator = "/";
            public const string Agent = nameof(Agent) + Separator;
            public const string Collision = Agent + nameof(Collision) + Separator;
        }
    }
}