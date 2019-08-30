using UnityEngine;
using UnityEngine.Events;

namespace GeneralComponents
{
    public abstract class GameAction<T, E, U> : MonoBehaviour, IGameAction<T> where E : GameEvent<T> where U : UnityEvent<T>
    {
        [SerializeField] private E gameEvent;
        [SerializeField] private int priority = 0;
        public U response;
        public int Priority => priority;
        //[SerializeField] UnityResponse response = new UnityResponse();


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

    public class GameAction : GameAction<Void, GameEvent, UnityVoidEvent> { }
}
