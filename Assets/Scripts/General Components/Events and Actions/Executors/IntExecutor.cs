using UnityEngine.Events;

namespace GeneralComponents
{
    public class IntExecutor : GameExecutor<int, IntAction, UnityIntEvent> { }

    [System.Serializable]
    public class UnityIntEvent : UnityEvent<int> { }
}
