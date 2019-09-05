using UnityEngine;
using UnityEngine.Events;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Game Event", menuName = GPUtility.EVENTS_PATH + "Game Event", order = 0)]
    public class GameEvent : ScriptableObject
    {
        [SerializeField] private UnityEvent eventActions;

        public void Raise()
        {
            eventActions?.Invoke();
        }
    } 
}