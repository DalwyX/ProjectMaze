using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Vector3 Var", menuName = "General / Variables / Vector3")]
    public class V3 : ScriptableObject
    {
        [SerializeField] private Vector3 val;
        [SerializeField] private bool readOnly;
        
        public Vector3 value
        {
            get
            {
                return val;
            }
            set
            {
                if (readOnly)
                {
                    Debug.Log("Попытка изменения readonly переменной!");
                    return;
                }
                val = value;
            }
        }
    } 
}
