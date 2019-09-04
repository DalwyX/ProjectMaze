using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeneralComponents;

namespace ProjectMaze
{
    [RequireComponent(typeof(Collider))]
    public class GameTrigger : MonoBehaviour
    {
        [SerializeField] private GameEvent triggerEvent;

        private void OnTriggerEnter(Collider other)
        {
            triggerEvent?.Raise();
        }
    } 
}
