using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneralComponents
{
    public class UIHelper : MonoBehaviour
    {
        [SerializeField] 
        private GameEvent openUI;
        private GameEvent closeUI;

        //public void OpenUI(UILayer ui)
        //{
        //    openUI.Notify(ui);
        //}

        //public void CloseUI()
        //{
        //    closeUI.Notify();
        //}

        public void OpenScene(int index)
        {
            //StartCoroutine(LoadRoutine(index));
        }

        public void ReloadScene()
        {
            //int index = SceneManager.GetActiveScene().buildIndex;
            //SceneManager.LoadScene(index);
        }

        //private IEnumerator LoadRoutine(int index)
        //{
        //    yield return SceneManager.LoadSceneAsync(index);
        //}
    } 
}
