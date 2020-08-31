using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodsplash : MonoBehaviour
{
    [SerializeField] Canvas splatter;
    [SerializeField] float wait = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        splatter.enabled = false;
    }
    public void showsplatter()
    {
        StartCoroutine(splattertime());
    }

    IEnumerator splattertime()
    {
        splatter.enabled = true;
        yield return new WaitForSeconds(wait);
        splatter.enabled = false;
    }
}
