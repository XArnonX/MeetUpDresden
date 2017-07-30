namespace MeetUp.Behaviors
{
    using System.Collections.Generic;

    using MeetUp.Models;

    using UnityEngine;

    [AddComponentMenu("Behaviors/Rotate")]
    public class RotateBehavior : MonoBehaviour
    {
        public float Speed = 20;

        [ContextMenuItem("Forward", "SetAxisForward")]
        [ContextMenuItem("Back", "SetAxisBack")]
        [ContextMenuItem("Left", "SetAxisLeft")]
        [ContextMenuItem("Right", "SetAxisRight")]
        [ContextMenuItem("Up", "SetAxisUp")]
        [ContextMenuItem("Down", "SetAxisDown")]
        public Vector3 Axis = Vector3.forward;

        // Use this for initialization
        private void Start()
        {

        }

        private void SetAxisForward()
        {
            Axis = Vector3.forward;
        }
        private void SetAxisBack()
        {
            Axis = Vector3.back;
        }
        private void SetAxisLeft()
        {
            Axis = Vector3.left;
        }
        private void SetAxisRight()
        {
            Axis = Vector3.right;
        }
        private void SetAxisUp()
        {
            Axis = Vector3.up;
        }
        private void SetAxisDown()
        {
            Axis = Vector3.down;
        }

        // Update is called once per frame
        private void Update()
        {
            transform.Rotate(Axis, Speed * Time.deltaTime);
        }
    }
}