using Robotics.Commands;
using UnityEngine;

namespace Robotics
{
    public class Robot : MonoBehaviour
    {
        [SerializeField] private Instruction _instruction = null!;

        private async void Start()
        {
            await new SequenceCommand(_instruction.Commands).ExecuteAsync(gameObject, destroyCancellationToken);
        }
    }
}
