using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class weaponhandler : MonoBehaviour
{

    [SerializeField] Camera fpcam;
    [SerializeField] float zoomedin = 20f;
    [SerializeField] float zoomedout = 60f;
    [SerializeField] float zoomedinsenstivity = 0.5f;
    [SerializeField] float zoomedoutsenstivity = 2f;
    RigidbodyFirstPersonController fpscontroller;
    private void Start()
    {
        fpscontroller = GetComponent<RigidbodyFirstPersonController>();
    }
    bool zoom = false;
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoom == false)
            {
                zoom = true;
                fpcam.fieldOfView = zoomedin;
                fpscontroller.mouseLook.XSensitivity = zoomedinsenstivity;
                fpscontroller.mouseLook.YSensitivity = zoomedinsenstivity;
            }
            else
            {
                zoom = false;
                fpcam.fieldOfView = zoomedout;
                fpscontroller.mouseLook.XSensitivity = zoomedoutsenstivity;
                fpscontroller.mouseLook.YSensitivity = zoomedoutsenstivity;
            }
        }
    }
}
