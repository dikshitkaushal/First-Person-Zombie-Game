using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammopickup : MonoBehaviour
{
    [SerializeField] int ammoamount = 5;
    [SerializeField] ammotype ammotype;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Destroy(gameObject);
            FindObjectOfType<ammo>().increaseammo(ammotype, ammoamount);
        }
    }
    
}
