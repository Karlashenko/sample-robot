using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Robotics.Data;
using UnityEngine;

namespace Robotics.Commands
{
    public class SequenceCommand : ICommand
    {
        private readonly List<ICommand> _commands;

        public SequenceCommand(IEnumerable<CommandData> commands)
        {
            _commands = commands.Select(CommandFactory.Create).ToList();
        }

        public async Task ExecuteAsync(GameObject subject, CancellationToken cancellationToken = default(CancellationToken))
        {
            foreach (var command in _commands)
            {
                await command.ExecuteAsync(subject, cancellationToken: cancellationToken);
            }
        }
    }
}
