using UnityEngine;

namespace MeetUp.ScriptableObjects.RotatingCube
{
    [CreateAssetMenu(fileName = "Rotating Cube", menuName = "Rotating Cube")]
    public class RotatingCubeData : ScriptableObject
    {
        public int Count;
        public GameObject Cube;
    }
}