using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Robotics.Data;
using UnityEngine;

namespace Robotics.Commands
{
    public class RotateCommand : ICommand
    {
        private readonly RotateCommandData _data;

        public RotateCommand(RotateCommandData data)
        {
            _data = data;
        }

        public async Task ExecuteAsync(GameObject subject, CancellationToken cancellationToken = default(CancellationToken))
        {
            await subject.transform.DORotate(_data.TargetRotation, _data.DurationSeconds)
                .ToUniTask(cancellationToken: cancellationToken);
        }

    }
}
