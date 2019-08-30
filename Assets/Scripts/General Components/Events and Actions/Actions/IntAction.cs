using UnityEngine.Events;

namespace GeneralComponents
{
    public class IntAction : GameAction<int, IntEvent, UnityIntEvent> { }

    [System.Serializable]
    public class UnityIntEvent : UnityEvent<int> { }
}
