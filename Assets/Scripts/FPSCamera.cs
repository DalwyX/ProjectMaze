using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectMaze
{
    public class FPSCamera : MonoBehaviour
    {
        [SerializeField] private float sensitivity = 5f;
        [SerializeField] private float smoothing = 2f;
        private Transform character;
        private Vector3 currentLook;
        private Vector3 smoothMov;

        private void Awake()
        {
            character = transform.parent;
        }

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            float h = Input.GetAxis("Mouse X");
            float v = Input.GetAxis("Mouse Y");

            Vector3 rot = new Vector3(h, v) * Time.deltaTime;
            currentLook += rot * sensitivity;
            currentLook.y = Mathf.Clamp(currentLook.y, -90f, 90f);

            smoothMov.x = Mathf.Lerp(smoothMov.x, rot.x, 1f / smoothing);
            smoothMov.y = Mathf.Lerp(smoothMov.y, rot.y, 1f / smoothing);
            currentLook += smoothMov;

            transform.localRotation = Quaternion.AngleAxis(-currentLook.y, Vector3.right);
            character.localRotation = Quaternion.AngleAxis(currentLook.x, character.transform.up);
        }
    } 
}
