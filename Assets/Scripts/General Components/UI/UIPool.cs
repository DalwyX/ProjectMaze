using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneralComponents
{
    public class UIPool : MonoBehaviour
    {
        [SerializeField] private UILayer defaultUILayer;
        private Dictionary<UILayer, Canvas> uiPool = new Dictionary<UILayer, Canvas>();
        private Stack<UILayer> uiStack = new Stack<UILayer>();

        private void Start()
        {
            OpenUI(defaultUILayer);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                UILayer element = uiStack.Peek().uiOnBackButton;
                if (element != null)
                {
                    OpenUI(element);
                }
                else
                {
                    CloseUI();
                }
            }
        }

        public void OpenUI(UILayer element)
        {
            if (!uiPool.ContainsKey(element))
            {
                PoolNewUI(element);
            }

            if (uiStack.Count > 0)
            {
                uiPool[uiStack.Peek()].gameObject.SetActive(false);
            }

            SetActiveUI(element);
        }

        public void CloseUI()
        {
            if (uiStack.Count > 1 && uiStack.Peek().isCloseable)
            {
                UILayer element = uiStack.Pop();
                uiPool[element].gameObject.SetActive(false);
                SetActiveUI(uiStack.Pop());
            }
        }

        private void PoolNewUI(UILayer element)
        {
            Canvas c = Instantiate(element.uiPrefab, transform);
            uiPool.Add(element, c);
        }

        private void SetActiveUI(UILayer element)
        {
            uiPool[element].gameObject.SetActive(true);
            Time.timeScale = element.uiTimeScale;
            Cursor.lockState = element.cursorLock;
            Cursor.visible = (Cursor.lockState != CursorLockMode.Locked);
            uiStack.Push(element);
        }
    } 
}
