using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class sceneloaader : MonoBehaviour
{
    public GameObject levelload;
    public Slider slide;
    public Text textt;
    public void levelloader(int sceneindex)
    {
        StartCoroutine(loadasynchrously(sceneindex));
    }
    IEnumerator loadasynchrously(int sceneindex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneindex);
        levelload.SetActive(true);
        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress/0.9f);
            slide.value = progress;
            textt.text = progress * 100f + "%";
            yield return null;
        }
    }
}
