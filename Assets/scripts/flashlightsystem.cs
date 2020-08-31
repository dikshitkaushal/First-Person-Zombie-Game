using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightsystem : MonoBehaviour
{
    [SerializeField] float lightdecay = 0.1f;
    [SerializeField] float angledecay = 1f;
    [SerializeField] float minangle = 40f;
    Light mylight;
        // Start is called before the first frame update
    void Start()
    {
        mylight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        decreaselightangle();
        decreaselightintensity();
    }
    public void restorelightintensity(float restoreintensity)
    {
        mylight.intensity += restoreintensity;
    }
    public void restorelightange(float restoreangle)
    {
        mylight.spotAngle = restoreangle;
    }
    private void decreaselightangle()
    {
        if(mylight.spotAngle<minangle)
        {
            return;
        }
        mylight.spotAngle -= angledecay*Time.deltaTime;
    }

    private void decreaselightintensity()
    {
        mylight.intensity -= lightdecay*Time.deltaTime;
    }
}
