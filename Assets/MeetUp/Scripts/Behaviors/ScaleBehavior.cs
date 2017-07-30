using UnityEngine;

namespace MeetUp.Behaviors
{
    [AddComponentMenu("Behaviors/Scale")]
    public class ScaleBehavior : MonoBehaviour
    {
        [HideInInspector]
        public float MaxScale = 2.0f;
        [HideInInspector]
        public float MinScale = 0.1f;
        [HideInInspector]
        public float Scale = 1.0f;
        
        public bool IsRaising = true;
        
        public float Speed = 10.0f;

        // Use this for initialization
        private void Start()
        {

        }

        // Update is called once per frame
        private void Update()
        {
            var change = Time.deltaTime * (IsRaising ? Speed : -Speed);
            var scale = transform.localScale.x + change;

            if (scale > MaxScale)
            {
                scale = MaxScale;
                IsRaising = false;
            }
            if (scale < MinScale)
            {
                scale = MinScale;
                IsRaising = true;
            }

            transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}