using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Game Action", menuName = "General / Events / Action")]
    public class GameAction : ScriptableObject
    {
        private List<ActionListener> actionListeners = new List<ActionListener>();

        public void Notify(Object go)
        {
            if (actionListeners.Count == 0) return;

            foreach (var listener in actionListeners)
            {
                listener.Notify(go);
            }
        }

        public void Subscribe(ActionListener actionListener)
        {
            actionListeners.Add(actionListener);
        }

        public void Unsubscribe(ActionListener actionListener)
        {
            actionListeners.Remove(actionListener);
        }
    } 
}
