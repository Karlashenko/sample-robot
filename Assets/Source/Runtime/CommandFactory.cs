using System;
using Robotics.Commands;
using Robotics.Data;

namespace Robotics
{
    public static class CommandFactory
    {
        public static ICommand Create(CommandData data)
        {
            switch (data.CommandType)
            {
                case CommandType.ChangeColor:
                    return Create<ChangeColorCommand, ChangeColorCommandData>(data);
                case CommandType.Move:
                    return Create<MoveCommand, MoveCommandData>(data);
                case CommandType.Rotate:
                    return Create<RotateCommand, RotateCommandData>(data);
            }

            throw new ArgumentOutOfRangeException();
        }

        private static ICommand Create<TCommand, TParameters>(CommandData data)
            where TCommand : ICommand
            where TParameters : CommandData
        {
            return (TCommand) Activator.CreateInstance(typeof(TCommand), (TParameters) data);
        }
    }
}
