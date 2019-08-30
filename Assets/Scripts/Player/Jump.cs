using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectMaze
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(Collider))]
    public class Jump : MonoBehaviour
    {
        [SerializeField] private float jumpForce = 5;
        private Rigidbody rb;
        private Collider col;
        private bool isJumpActivate;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            col = GetComponent<Collider>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PerformJump();
            }
        }

        private void PerformJump()
        {
            if (isGrounded() && isJumpActivate)
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
        }

        private bool isGrounded()
        {
            return Physics.Raycast(transform.position, Vector3.down, col.bounds.extents.y + 0.1f);
        }

        public void UnlockJump()
        {
            isJumpActivate = true;
        }
    } 
}