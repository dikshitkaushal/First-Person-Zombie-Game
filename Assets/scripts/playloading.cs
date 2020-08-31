using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playloading : MonoBehaviour
{
    [SerializeField] GameObject loadingbarcanvas;
    [SerializeField] Image loadingbar;
    public static playloading instance;
    private float progressvalue = 1.1f;
    private float progressmultipler1 = 0.5f;
    private float progressmultiplier2 = 0.07f;
    private void Awake()
    {
        singelton();
    }

    private void singelton()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadinglevelscreen());
    }

    // Update is called once per frame
    void Update()
    {
        loadingscreen();
    }
    public void loadlevel(int index)
    {
        loadingbarcanvas.SetActive(true);
        progressvalue = 0f;
        Time.timeScale = 0f;
        SceneManager.LoadScene(index);
    }
    void loadingscreen()
    {
        if(progressvalue<1)
        {
            progressvalue += progressmultipler1 * progressmultiplier2;
            loadingbar.fillAmount = progressvalue;
            if(progressvalue>1)
            {
                progressvalue = 1.1f;
                loadingbar.fillAmount = 0;
                loadingbarcanvas.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
    IEnumerator loadinglevelscreen()
    {
        yield return new WaitForSeconds(3f);
        loadlevel(1);
    }
}
