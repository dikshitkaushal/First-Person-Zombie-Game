using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playaudio : MonoBehaviour
{
    [SerializeField] AudioSource audioo1;
    public void audioplay1()
    {
        audioo1.Play();
    }
}
