using System.Collections.Generic;
using Robotics.Commands;
using UnityEngine;

namespace Robotics
{
    public class Robot : MonoBehaviour
    {
        [SerializeField] private List<Instruction> _instructions = new();

        private async void Start()
        {
            foreach (var instruction in _instructions)
            {
                await new SequenceCommand(instruction.Commands)
                    .ExecuteAsync(gameObject, destroyCancellationToken);
            }
        }
    }
}
