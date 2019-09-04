using UnityEngine.Events;

namespace GeneralComponents
{
    [System.Serializable]
    public class UnityVoidEvent : UnityEvent<Void> { }

    public class VoidExecutor : GameExecutor<Void, VoidAction, UnityVoidEvent> { } 
}