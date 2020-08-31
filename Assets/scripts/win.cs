using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    public AudioSource source;
    public int k;
    enemyheath health;
    // Start is called before the first frame update
    void Start()
    {
        k = 0;
        canvas.enabled = false;
        health =GetComponentInChildren<enemyheath>();
       
    }

    // Update is called once per frame
    public void youwon()
    {
        if(health.isdead())
        {
            k++;
            if (k == 23)
            {
                StartCoroutine(finale());
            }
            else
            {
                return;
            }
            IEnumerator finale()
            {
                source.Play();
                canvas.enabled = true;
                yield return new WaitForSeconds(1);
                Time.timeScale = 0;
                Application.Quit();
            }
        }
    }
}
