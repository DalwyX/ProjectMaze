using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GeneralComponents
{
    public class EventListener : MonoBehaviour
    {
        [SerializeField] private GameEvent gameEvent;
        [SerializeField] private UnityEvent response;

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

        public void Notify()
        {
            response?.Invoke();
        }
    }
}