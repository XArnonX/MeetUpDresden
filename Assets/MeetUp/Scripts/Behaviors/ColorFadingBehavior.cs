using UnityEngine;

namespace MeetUp.Behaviors
{
    using System.Collections;

    [AddComponentMenu("Behaviors/Color Fading")]
    public class ColorFadingBehavior : MonoBehaviour
    {
        private Renderer _renderer;

        public float Speed = 10;

        private bool _restart = true;

        // Use this for initialization
        private void Start()
        {
            _renderer = GetComponent<Renderer>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (_restart)
            {
                StartCoroutine(Fade());
            }
        }

        private IEnumerator Fade()
        {
            _restart = false;
            for (var f = 1.0f; f >= 0.0f; f -= Time.deltaTime * Speed / 10)
            {
                var c = _renderer.material.color;
                c.g = f;
                _renderer.material.color = c;
                yield return null;
            }

            for (var f = 0.0f; f <= 1.0f; f += Time.deltaTime * Speed / 10)
            {
                var c = _renderer.material.color;
                c.g = f;
                _renderer.material.color = c;
                yield return null;
            }

            _restart = true;
        }

    }
}