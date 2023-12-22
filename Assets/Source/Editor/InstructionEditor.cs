using UnityEditor;
using UnityEngine;

namespace Robotics.Editor
{
    [CustomEditor(typeof(Instruction))]
    public class InstructionEditor : UnityEditor.Editor
    {
        private Instruction _instruction = null!;
        private CommandType _commandType;

        private void OnEnable()
        {
            _instruction = (Instruction) target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUILayout.Space(25);

            _commandType = (CommandType) EditorGUILayout.EnumPopup(_commandType);

            if (_commandType == CommandType.Undefined)
            {
                GUILayout.Label("Please select proper command type");
                return;
            }

            if (GUILayout.Button("Add Command"))
            {
                _instruction.AddCommand(_commandType);
            }
        }
    }
}
