using UnityEngine.Events;

namespace GeneralComponents
{
    public class BoolExecutor : GameExecutor<bool, BoolAction, UnityBoolEvent> { }

    [System.Serializable]
    public class UnityBoolEvent : UnityEvent<bool> { }
}