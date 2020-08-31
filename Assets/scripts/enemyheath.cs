using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyheath : MonoBehaviour
{
    [SerializeField] float hitpoints = 100f;
    bool dead = false;
    public bool isdead()
    {
        return dead;
    }
    public void health(float damage)
    {
        BroadcastMessage("damagetaken");
        hitpoints -= damage;
        if(hitpoints<=0)
        {
            Die();
        }
        else
        {
            return;
        }
    }

    private void Die()
    {
        if(dead==true)
        {
            return;
        }
        dead = true;
        GetComponent<Animator>().SetTrigger("die") ;
    }
}
