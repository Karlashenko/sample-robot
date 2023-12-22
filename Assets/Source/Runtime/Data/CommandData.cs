using System;

namespace Robotics.Data
{
    [Serializable]
    public class CommandData
    {
        public CommandType CommandType;
        public float DurationSeconds;
    }
}
