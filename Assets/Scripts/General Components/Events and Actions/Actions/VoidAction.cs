using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Void Action", menuName = "General Components / Events and Actions / Void Action", order = 1)]
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