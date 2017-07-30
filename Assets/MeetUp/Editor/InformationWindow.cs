namespace MeetUp.Editor
{
    using UnityEditor;

    using UnityEngine;

    public class InformationWindow : EditorWindow
    {
        [MenuItem("MeetUp/Informations")]
        public static void ShowWindow()
        {
            GetWindow(typeof(InformationWindow));
        }

        public void OnGUI()
        {
            titleContent = new GUIContent("Informations");
            GUILayout.Label("Event", EditorStyles.boldLabel);
            GUILayout.Label("A (not so) Short Introduction to Unity");

            GUILayout.Space(10);

            GUILayout.Label("Referenten", EditorStyles.boldLabel);
            GUILayout.Label("Maximilian Klockmann");
            GUILayout.Label("Gerd Schmidt");

            GUILayout.Space(10);

            GUILayout.Label("Objects in Scene:", EditorStyles.boldLabel);
            GUILayout.Label(FindObjectsOfType<Transform>().Length + " Transforms");
        }

    }
}