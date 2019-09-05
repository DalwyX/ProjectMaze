using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New String Action", menuName = GPUtility.EVENTS_PATH + "String Action", order = 5)]
    public class StringAction : GameAction<string> { }
}