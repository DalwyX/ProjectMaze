using UnityEngine;
using UnityEngine.Events;

namespace GeneralComponents
{
    public abstract class GameExecutor<T, E, U> : MonoBehaviour, IGameExecutor<T> where E : GameAction<T> where U : UnityEvent<T>
    {
        [SerializeField] private E gameAction;
        public U response;

        [System.Serializable]
        public class UnityResponse : UnityEvent<T> { }

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

        public void Execute(T arg)
        {
            response?.Invoke(arg);
        }
    }
}
