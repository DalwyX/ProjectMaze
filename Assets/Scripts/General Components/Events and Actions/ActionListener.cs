using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GeneralComponents
{
    public class ActionListener : MonoBehaviour
    {
        [SerializeField] private GameAction gameAction;
        [SerializeField] private Response response;

        

        private void OnEnable()
        {
            if (gameAction == null) return;
            gameAction.Subscribe(this);
        }

        private void OnDisable()
        {
            if (gameAction == null) return;
            gameAction.Unsubscribe(this);
        }

        public void Notify(Object go)
        {
            response?.Invoke(go);
        }
    }

    [System.Serializable]
    class Response : UnityEvent<Object> { }
}