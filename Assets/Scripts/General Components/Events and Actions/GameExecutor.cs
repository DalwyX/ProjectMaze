using UnityEngine;
using UnityEngine.Events;

namespace GeneralComponents
{
    public abstract class GameExecutor<T, E, U> : MonoBehaviour, IGameExecutor<T> where E : GameAction<T> where U : UnityEvent<T>
    {
        [SerializeField] private E gameEvent;
        public U response;

        [System.Serializable]
        public class UnityResponse : UnityEvent<T> { }

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

        public void Execute(T arg)
        {
            response?.Invoke(arg);
        }
    }

    [System.Serializable]
    public class UnityVoidEvent : UnityEvent<Void> { }

    public class VoidExecutor : GameExecutor<Void, VoidAction, UnityVoidEvent> { }
}
