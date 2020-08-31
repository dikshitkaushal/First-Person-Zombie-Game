using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasdisplay : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled = false;
        StartCoroutine(showcanvas());
    }

    IEnumerator showcanvas()
    {
        yield return new WaitForSeconds(0.3f);
        canvas.enabled = true;
    }
}
