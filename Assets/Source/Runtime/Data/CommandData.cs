using System;
using Robotics.Utility;

namespace Robotics.Data
{
    [Serializable]
    public class CommandData
    {
        [ReadOnly] public CommandType CommandType;
        public float DurationSeconds;
    }
}
