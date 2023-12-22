using System;
using UnityEngine;

namespace Robotics.Data
{
    [Serializable]
    public class ChangeColorCommandData : CommandData
    {
        public Color Color;
    }
}
