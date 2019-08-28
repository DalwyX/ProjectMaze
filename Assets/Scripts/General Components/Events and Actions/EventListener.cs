using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GeneralComponents
{

    [System.Serializable]
    public class UnityEventWithArgument : UnityEvent<Object> { }

    public class EventListener : MonoBehaviour
    {
        [SerializeField] private GameEvent gameEvent;
        public UnityEventWithArgument response = new UnityEventWithArgument();

        private void OnEnable()
        {
            if (gameEvent == null) return;
            gameEvent.Subscribe(this);
        }

        private void OnDisable()
        {
            if (gameEvent == null) return;
            gameEvent.Unsubscribe(this);
        }

        public void Notify(Object o = null)
        {
            response?.Invoke(o);
        }
    }

}