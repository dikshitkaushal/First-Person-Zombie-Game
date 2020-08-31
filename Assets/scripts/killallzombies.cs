using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killallzombies : MonoBehaviour
{
    public AudioSource source;
    [SerializeField] Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;
        StartCoroutine(canvass());
    }

    IEnumerator canvass()
    {
        yield return new WaitForSeconds(0.5f);
        canvas.enabled = true;
        source.Play();
        yield return new WaitForSeconds(2.5f);
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
