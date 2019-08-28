using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New UI Layer", menuName = "General Components / UI / UILayer")]
    public class UILayer : ScriptableObject
    {
        [SerializeField] private Canvas UIPrefab;
        [SerializeField] private UILayer backButtonUI = null;
        [SerializeField] private float UITimeScale = 1f;
        [SerializeField] private CursorLockMode cursorLockMode = CursorLockMode.None;
        [SerializeField] private bool closeable = true;
        public Canvas uiPrefab => UIPrefab;
        public bool isCloseable => closeable;
        public UILayer uiOnBackButton => backButtonUI;
        public CursorLockMode cursorLock => cursorLockMode;
        public float uiTimeScale => UITimeScale;
    } 
}
