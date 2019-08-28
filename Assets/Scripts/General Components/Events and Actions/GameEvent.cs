using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Game Event", menuName = "General Components / Events / Event")]
    public class GameEvent : ScriptableObject
    {
        private List<EventListener> eventListeners = new List<EventListener>();

        public void Action()
        {
            Notify();
        }

        public void Action(int n)
        {
            Int o = CreateInstance<Int>();
            o.value = n;
            Notify(o);
        }

        public void Action(Object v)
        {
            Notify(v);
        }

        private void Notify(Object o = null)
        {
            if (eventListeners.Count == 0) return;

            foreach (var listener in eventListeners)
            {
                listener.Notify(o);
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
