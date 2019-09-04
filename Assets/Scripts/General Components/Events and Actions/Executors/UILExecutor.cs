using UnityEngine.Events;

namespace GeneralComponents
{
    public class UILExecutor : GameExecutor<UILayer, UILAction, UnityUILEvent> { }

    [System.Serializable]
    public class UnityUILEvent : UnityEvent<UILayer> { }
}
