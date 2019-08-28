using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GeneralComponents
{
    public class UIHelper : MonoBehaviour
    {
        public void LoadScene(Object sceneIndex)
        {
            int index = ((Int)sceneIndex).value;
            StartCoroutine(LoadSceneRoutine(index));
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        private IEnumerator LoadSceneRoutine(int index)
        {
            yield return SceneManager.LoadSceneAsync(index);
        }
    } 
}
