using System.Collections.Generic;
using System.Linq;
using Robotics.Data;
using UnityEngine;

namespace Robotics
{
    [CreateAssetMenu(menuName = "Instruction")]
    public class Instruction : ScriptableObject
    {
        [SerializeReference] public List<CommandData> Commands = new();

        private void OnValidate()
        {
            Commands = Commands.Where(x => x is not null).ToList();
        }
    }
}
