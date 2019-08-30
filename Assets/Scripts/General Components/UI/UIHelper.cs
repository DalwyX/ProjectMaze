using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GeneralComponents
{
    public class UIHelper : MonoBehaviour
    {
        public void LoadScene(int sceneIndex)
        {
            StartCoroutine(LoadSceneRoutine(sceneIndex));
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
