using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Void Action", menuName = GPUtility.EVENTS_PATH + "Void Action", order = 1)]
    public class VoidAction : GameAction<Void>
    {
        public void Notify()
        {
            Notify(new Void());
        }
    }

    [System.Serializable]
    public struct Void { }
}