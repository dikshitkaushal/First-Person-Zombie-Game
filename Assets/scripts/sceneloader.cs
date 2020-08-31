using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    playaudio audioo;
    enemyAI enemy;
    private void Start()
    {
        audioo = FindObjectOfType<playaudio>();
        enemy = FindObjectOfType<enemyAI>();
    }
    public void reloadgame()
    {
        Time.timeScale = 1;
        StartCoroutine(audiop());
        SceneManager.LoadScene(1);
    }
    IEnumerator audiop()
    {
        audioo.audioplay1();
        yield return new WaitForSeconds(1f);
    }

    public void quitgame()
    {
        audioo.audioplay1();
        Application.Quit();
    }
}
