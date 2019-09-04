using System.Collections.Generic;
using UnityEngine;

namespace GeneralComponents
{
    public abstract class GameAction<T> : ScriptableObject
    {
        [SerializeField] private List<IGameExecutor<T>> gameActions = new List<IGameExecutor<T>>();

        public void Notify(T arg)
        {
            if (gameActions.Count == 0) return;

            for (int i = gameActions.Count - 1; i >= 0; i--)
            {
                gameActions[i].Execute(arg);
            }
        }

        public void Subscribe(IGameExecutor<T> gameAction)
        {
            if (gameActions.Contains(gameAction)) return;
            gameActions.Add(gameAction);
        }

        public void Unsubscribe(IGameExecutor<T> gameAction)
        {
            if (gameActions.Contains(gameAction))
                gameActions.Remove(gameAction);
        }
    }
}
