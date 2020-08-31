using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    [SerializeField] float hitpoints = 100f;
    deathhandler death;
    decreaseheathbar decrease;
    private void Start()
    {
        death = FindObjectOfType<deathhandler>();
        decrease = FindObjectOfType<decreaseheathbar>();
    }
    public void attack(float damage)
    {

        hitpoints -= damage;
        decrease.healthdecrease(damage);

        if(hitpoints<0)
        {
            decrease.healthzero();
            death.deathhandle();
            Debug.Log("YOU ARE DEAD ");
        }
    }
}
