using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectMaze
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float speed = 5;

        private void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 dir = new Vector3(h, 0, v);

            transform.Translate(dir * speed * Time.deltaTime);
        }
    } 
}
