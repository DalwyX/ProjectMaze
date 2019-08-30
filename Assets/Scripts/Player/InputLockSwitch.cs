using UnityEngine;
using GeneralComponents;

namespace ProjectMaze
{
    [RequireComponent(typeof(Collider))]
    public class InputLockSwitch : MonoBehaviour
    {
        [SerializeField] private Bool lockInput;
        [SerializeField] private LockAction lockAction;
        [SerializeField] private string colliderTag = "MainCamera";


        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == colliderTag)
            {
                lockInput.value = (lockAction == LockAction.Lock);
            }
        }
    }

    enum LockAction { Lock, Unlock }
}
