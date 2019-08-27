using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Game Event", menuName = "General / Events / Event")]
    public class GameEvent : ScriptableObject
    {
        private List<EventListener> eventListeners = new List<EventListener>();

        public void Notify()
        {
            if (eventListeners.Count == 0) return;

            foreach(var listener in eventListeners)
            {
                listener.Notify();
            }
        }

        public void Subscribe(EventListener eventListener)
        {
            eventListeners.Add(eventListener);
        }

        public void Unsubscribe(EventListener eventListener)
        {
            eventListeners.Remove(eventListener);
        }
    }
}
