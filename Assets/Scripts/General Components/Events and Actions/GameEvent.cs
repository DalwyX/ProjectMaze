using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GeneralComponents
{
    public abstract class GameEvent<T> : ScriptableObject
    {
        [SerializeField] private List<IGameAction<T>> gameActions = new List<IGameAction<T>>();

        public void Notify(T arg)
        {
            if (gameActions.Count == 0) return;
            gameActions = gameActions.OrderBy(k => k.Priority).ToList();

            for (int i = gameActions.Count - 1; i >= 0; i--)
            {
                gameActions[i].Execute(arg);
            }
        }

        public void Subscribe(IGameAction<T> gameAction)
        {
            if (gameActions.Contains(gameAction)) return;
            gameActions.Add(gameAction);
        }

        public void Unsubscribe(IGameAction<T> gameAction)
        {
            if (gameActions.Contains(gameAction))
                gameActions.Remove(gameAction);
        }
    }

    [CreateAssetMenu(fileName = "New Game Event", menuName = "General Components / Events / Game Event", order = 0)]
    public class GameEvent : GameEvent<Void>
    {
        public void Notify()
        {
            Notify(new Void());
        }
    }

    [System.Serializable]
    public struct Void { }
}
