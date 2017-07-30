namespace MeetUp.Behaviors
{
    using MeetUp.Models;

    using UnityEditor;

    using UnityEngine;

    [CustomPropertyDrawer(typeof(KeyValue))]
    public class KeyValueDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;
            
            var keysRect = new Rect(position.x, position.y, position.width / 2, position.height);
            var valueRect = new Rect(position.x + position.width / 2, position.y, position.width / 2, position.height);

            EditorGUI.DelayedTextField(keysRect, property.FindPropertyRelative("Key"), GUIContent.none);
            EditorGUI.ObjectField(valueRect, property.FindPropertyRelative("Value"), GUIContent.none);

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
}