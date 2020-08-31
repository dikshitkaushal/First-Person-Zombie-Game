using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delay : MonoBehaviour
{
    public Canvas source;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(breathh());
    }
    IEnumerator breathh()
    {
        source.enabled = false;
        yield return new WaitForSeconds(1f);
        source.enabled = true;
    }
}
