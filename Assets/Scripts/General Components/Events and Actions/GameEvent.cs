using UnityEngine;
using UnityEngine.Events;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Game Event", menuName = "General Components / Events and Actions / Game Event", order = 0)]
    public class GameEvent : ScriptableObject
    {
        [SerializeField] private UnityEvent eventActions;

        public void Raise()
        {
            eventActions?.Invoke();
        }
    } 
}