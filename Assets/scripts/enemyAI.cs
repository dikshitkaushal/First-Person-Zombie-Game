using System;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    [SerializeField] float volume = 0.62f;
    [SerializeField] Transform target;
    [SerializeField] float chaserange = 6f;
    [SerializeField] float turnspeed = 13f;
    NavMeshAgent navmeshagent;
    float distancetotarget = Mathf.Infinity;
    bool isprovoke = false;
    public AudioSource source;
    win won;
  //  float AudioSource audio;
    enemyheath health;
    // Start is called before the first frame update
    void Start()
    {
        won = FindObjectOfType<win>();
        health = GetComponent<enemyheath>();
        navmeshagent = GetComponent<NavMeshAgent>();
        GetComponent<Animator>().SetTrigger("idle");
    }
    // Update is called once per frame
    void Update()
    {
         distancetotarget = Vector3.Distance(target.position, transform.position);

            if (health.isdead())
            {
                won.youwon();
                source.volume = 0;
                this.enabled = false;
                navmeshagent.enabled = false;
            }

            else if (!health.isdead())

            {
                if (isprovoke)

                {
                    engagetarget();

                }

                else if (distancetotarget <= chaserange)

                {
                    source.volume = volume;
                    isprovoke = true;
                    source.Play();
                    chasetarget();

                }

            }
    }
    public void damagetaken()
    {
        if (!health.isdead())
        {
            source.volume = volume;
            isprovoke = true;
            source.Play();
        }
    }
    public void engagetarget()
    {
        facetarget();
        if(distancetotarget >= navmeshagent.stoppingDistance)
        {
            chasetarget();
        }
        else if(distancetotarget<=navmeshagent.stoppingDistance)
        {
            attacktarget();
        }
    }
    public void attacktarget()
    {
        GetComponent<Animator>().SetBool("attack", true);
    }

    public void chasetarget()
    {
        GetComponent<Animator>().SetBool("attack", false);
        GetComponent<Animator>().SetTrigger("move");
        navmeshagent.SetDestination(target.position);
    }
    public void facetarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookrotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookrotation,Time.deltaTime*turnspeed);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaserange);
    }
}