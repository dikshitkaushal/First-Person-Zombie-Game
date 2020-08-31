using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathhandler : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    enemyAI enemy;
    weapons weapons;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        enemy = FindObjectOfType<enemyAI>();
        weapons = FindObjectOfType<weapons>();
        canvas.enabled = false;
    }
    public void deathhandle()
    {
        source.Stop();
        enemy.source.Stop();
        weapons.audio1.volume = 0;
        weapons.audio2.volume = 0;
        weapons.audio3.volume = 0;
        Time.timeScale = 0;
        FindObjectOfType<weaponchanger>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        canvas.enabled = true;
        Cursor.visible = true;
    }

}
