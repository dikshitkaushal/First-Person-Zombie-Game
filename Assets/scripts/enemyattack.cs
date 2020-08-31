using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{
    [SerializeField] float damage = 40f;
    playerhealth target;
    // Start is called before the first frame update
    void Start()
    {
        target=FindObjectOfType<playerhealth>();
    }
    public void attackhitevent()
    {
        if(target==null)
        {
            return;
        }
        else
        {
            target.GetComponent<bloodsplash>().showsplatter();
            target.attack(damage);
        }
        
    }

}
