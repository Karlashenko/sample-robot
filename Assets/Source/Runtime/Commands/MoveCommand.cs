using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Robotics.Data;
using UnityEngine;

namespace Robotics.Commands
{
    public class MoveCommand : ICommand
    {
        private readonly MoveCommandData _data;

        public MoveCommand(MoveCommandData data)
        {
            _data = data;
        }

        public async Task ExecuteAsync(GameObject subject, CancellationToken cancellationToken = default(CancellationToken))
        {
            await subject.transform.DOMove(_data.TargetPosition, _data.DurationSeconds)
                .ToUniTask(cancellationToken: cancellationToken);
        }

    }
}
