using UnityEngine;

namespace MeetUp
{
    using UnityEngine.SceneManagement;

    public class SceneLoading : MonoBehaviour
    {

        // Use this for initialization
        private void Start()
        {

        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
                SceneManager.LoadScene("SceneManager", LoadSceneMode.Single);
            if (Input.GetKeyDown(KeyCode.S))
                SceneManager.LoadScene("LoadAdditive", LoadSceneMode.Additive);
        }
    }
}