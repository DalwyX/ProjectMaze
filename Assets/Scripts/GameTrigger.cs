using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeneralComponents;

namespace ProjectMaze
{
    [RequireComponent(typeof(Collider))]
    public class GameTrigger : MonoBehaviour
    {
        [SerializeField] private UILAction triggerEvent;
        [SerializeField] private UILayer layerToLoad;

        private void OnTriggerEnter(Collider other)
        {
            triggerEvent?.Notify(layerToLoad);
        }
    } 
}
