using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class weapons : MonoBehaviour
{
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    [SerializeField] Camera fpcam;
    [SerializeField] float range = 500f;
    [SerializeField] float damage = 30f;
    [SerializeField] ParticleSystem muzzle;
    [SerializeField] ammotype ammotype;
    [SerializeField] GameObject effect;
    [SerializeField] ammo rammo;
    [SerializeField] float timebetweenshots = 2f;
    [SerializeField] TextMeshProUGUI ammotext;
    weaponchanger weapon;
    float timedelay = 0.1f;
    bool canshoot = true;
    int currentammo;
    private void OnEnable()
    {
        canshoot = true;
    }
    void Update()
    {
       
        if (Input.GetButton("Fire1") && canshoot == true)
        {

            StartCoroutine(Shoot());
        }
        displayammo();
    }

    private void Start()
    {
        weapon = FindObjectOfType<weaponchanger>();
    }
    private void displayammo()
    {
        currentammo = rammo.currentammo(ammotype);
        ammotext.text = currentammo.ToString();
    }

    IEnumerator Shoot()
    {
        canshoot = false;
        if(ammotype==ammotype.bullets)
        {
            audio1.Play();
        }
        if (ammotype == ammotype.rocket)
        {
            audio2.Play();
        }
        if (ammotype == ammotype.shellsgauge)
        {
            audio3.Play();
        }
        if (currentammo == 0 && ammotype == ammotype.bullets)
        {
            audio1.Stop(); ;
        }
        if (currentammo == 0 && ammotype == ammotype.rocket)
        {
            audio2.Stop();
        }
        if (currentammo == 0 && ammotype == ammotype.shellsgauge)
        {
            audio3.Stop();
        }
        if (rammo.currentammo(ammotype) > 0)
        {
            currentammo = rammo.decreaseammo(ammotype);
            muzzleeffect();
            raycastprocss();
        }
        yield return new WaitForSeconds(timebetweenshots);
        audio1.Stop();

        audio2.Stop();
        audio3.Stop();
        canshoot = true;
    }

    private void muzzleeffect()
    {
        muzzle.Play();
    }

    private void raycastprocss()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpcam.transform.position, fpcam.transform.forward, out hit, range))
        {
            Debug.Log("i hit something " + hit.transform.name);
            createhitimpact(hit);
            enemyheath target = hit.transform.GetComponent<enemyheath>();
            if (target == null)
            {
                return;
            }
            target.health(damage);
        }
        else
        {
            return;
        }
    }

    private void createhitimpact(RaycastHit hit)
    {
        GameObject effects=Instantiate(effect,hit.point,Quaternion.LookRotation(hit.normal));
        Destroy(effects, timedelay);
    }
}