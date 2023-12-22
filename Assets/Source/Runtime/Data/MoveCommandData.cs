using System;
using UnityEngine;

namespace Robotics.Data
{
    [Serializable]
    public class MoveCommandData : CommandData
    {
        public Vector3 TargetPosition;
    }
}
