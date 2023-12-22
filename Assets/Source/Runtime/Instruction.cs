using System;
using System.Collections.Generic;
using System.Linq;
using Robotics.Data;
using UnityEngine;

namespace Robotics
{
    [CreateAssetMenu(menuName = "Instruction")]
    public class Instruction : ScriptableObject
    {
        public IEnumerable<CommandData> Commands => _commands;

        [SerializeField]
        [SerializeReference]
        private List<CommandData> _commands = new();

        public void AddCommand(CommandType commandType)
        {
            _commands.Add(CreateCommandByType(commandType));
        }

        private void OnValidate()
        {
            _commands = _commands.Where(x => x is not null).ToList();
        }

        private static CommandData CreateCommandByType(CommandType commandType)
        {
            switch (commandType)
            {
                case CommandType.ChangeColor:
                    return new ChangeColorCommandData { CommandType = commandType };
                case CommandType.Move:
                    return new MoveCommandData { CommandType = commandType };
                case CommandType.Rotate:
                    return new RotateCommandData { CommandType = commandType };
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
