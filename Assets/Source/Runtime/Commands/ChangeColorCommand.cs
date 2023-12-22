using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Robotics.Data;
using UnityEngine;

namespace Robotics.Commands
{
    public class ChangeColorCommand : ICommand
    {
        private readonly ChangeColorCommandData _data;

        public ChangeColorCommand(ChangeColorCommandData data)
        {
            _data = data;
        }

        public async Task ExecuteAsync(GameObject subject, CancellationToken cancellationToken = default(CancellationToken))
        {
            await subject.GetComponent<Renderer>().material.DOColor(_data.Color, _data.DurationSeconds)
                .ToUniTask(cancellationToken: cancellationToken);
        }
    }
}
