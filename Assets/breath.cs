using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breath : MonoBehaviour
{
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(breathh());
    }
    IEnumerator breathh()
    {
        yield return new WaitForSeconds(1f);
        source.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
