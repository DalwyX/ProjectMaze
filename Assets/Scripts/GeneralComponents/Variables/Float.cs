using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Float Var", menuName = "General / Variables / Float")]
    public class Float : ScriptableObject
    {
        [SerializeField] private float val;
        [SerializeField] private bool readOnly;

        public float value
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
