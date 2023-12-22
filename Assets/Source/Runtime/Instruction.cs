using System.Collections.Generic;
using Robotics.Data;
using UnityEngine;

namespace Robotics
{
    [CreateAssetMenu(menuName = "Instruction")]
    public class Instruction : ScriptableObject
    {
        [SerializeReference] public List<CommandData> Commands = new();
    }
}
