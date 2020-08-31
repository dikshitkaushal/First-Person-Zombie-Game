using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponchanger : MonoBehaviour
{
    [SerializeField] int currweapon = 0;
    void Start()
    {
        chooseweapon();
    }
    // Update is called once per frame
    void Update()
    {
        int previousweapon = currweapon;
        processkeyinput();
        processscrollinput();
        if(previousweapon!=currweapon)
        {
            chooseweapon();
        }
    }

    public void processscrollinput()
    {
        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if ((currweapon == transform.childCount - 1))
            {
                currweapon=0;
            }
            else
            {
                currweapon++;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if ((currweapon <=0))
            {
                currweapon=transform.childCount-1;
            }
            else
            {
                currweapon--;
            }
        }
    }

    public void processkeyinput()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            currweapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currweapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currweapon = 2;
        }
    }

    public void chooseweapon()
    {
        int currentweapon = 0;
        foreach (Transform weapon in transform)
        {
            if (currentweapon == currweapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            currentweapon++;
        }
    }
}
