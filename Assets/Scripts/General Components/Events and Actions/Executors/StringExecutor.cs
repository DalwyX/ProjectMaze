using UnityEngine.Events;

namespace GeneralComponents
{
    public class StringExecutor : GameExecutor<string, StringAction, UnityStringEvent> { }

    [System.Serializable]
    public class UnityStringEvent : UnityEvent<string> { }
}
