using UnityEngine;

namespace MeetUp.Manager
{
    using MeetUp.ScriptableObjects.RotatingCube;

    public class RotatingCubeManager : MonoBehaviour
    {
        public RotatingCubeData Configuration;

        // Use this for initialization
        private void Start()
        {
            for (var i = Configuration.Count / -2; i <= Configuration.Count / 2; i++)
            {
                var cube = Instantiate(Configuration.Cube);
                cube.transform.position = new Vector3(i * 2, 0, 0);
                cube.transform.parent = transform;
            }
        }
    }
}