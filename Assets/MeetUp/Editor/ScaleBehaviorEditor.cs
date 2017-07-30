namespace MeetUp.Editor
{

    using MeetUp.Behaviors;

    using UnityEditor;

    using Editor = UnityEditor.Editor;

    [CustomEditor(typeof(ScaleBehavior))]
    public class ScaleBehaviorEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var min = serializedObject.FindProperty("MinScale");
            var max = serializedObject.FindProperty("MaxScale");

            EditorGUILayout.DelayedFloatField(min);
            EditorGUILayout.Slider(serializedObject.FindProperty("Scale"), min.floatValue, max.floatValue);
            EditorGUILayout.DelayedFloatField(max);

            serializedObject.ApplyModifiedProperties();
        }
    }
}