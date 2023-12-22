using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Robotics.Commands
{
    public interface ICommand
    {
        Task ExecuteAsync(GameObject subject, CancellationToken cancellationToken = default(CancellationToken));
    }
}
