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
                    return new ChangeColorCommand((ChangeColorCommandData) data);
                case CommandType.Move:
                    return new MoveCommand((MoveCommandData) data);
                case CommandType.Rotate:
                    return new RotateCommand((RotateCommandData) data);
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
