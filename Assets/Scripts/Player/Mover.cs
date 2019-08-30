using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeneralComponents;

namespace ProjectMaze
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float speed = 5;
        [SerializeField] private float runSpeedMod = 2;
        [SerializeField] private Bool inputLock;
        private bool isRunActivate;

        private void Awake()
        {
            inputLock.value = true;
        }

        private void Update()
        {
            if (inputLock.value) return;
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 dir = new Vector3(h, 0, v);

            float curSpeed = (Input.GetKey(KeyCode.LeftShift) && isRunActivate) ? speed * runSpeedMod : speed;
            transform.Translate(dir * curSpeed * Time.deltaTime);
        }

        public void UnlockRun()
        {
            isRunActivate = true;
        }
    }
}
