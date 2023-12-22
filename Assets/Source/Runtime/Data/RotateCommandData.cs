using System;
using UnityEngine;

namespace Robotics.Data
{
    [Serializable]
    public class RotateCommandData : CommandData
    {
        public Vector3 TargetRotation;
    }
}
