using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walker : MonoBehaviour
{
    //CharacterController cc;
    public AudioSource source;
    // Start is called before the first frame update
   /* void Start()
    {
       // cc = GetComponent<CharacterController>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cc.isGrounded==true && cc.velocity.magnitude>=2 && source.isPlaying==false)
        {
            source.volume = Random.Range(0.8f, 1f);
            source.pitch = Random.Range(0.8f, 1.1f);
            source.Play();
        }
    }*/
}
