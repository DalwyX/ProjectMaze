using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New String Variable", menuName = GPUtility.VARIABLES_PATH + "String", order = 3)]
    public class String : Variable<string> { }
}