using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batterypickup : MonoBehaviour
{
    [SerializeField] float restoreintensity = 5f;
    [SerializeField] float restoreangle = 50f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<flashlightsystem>().restorelightintensity(restoreintensity);
            other.GetComponentInChildren<flashlightsystem>().restorelightange(restoreangle);
            Destroy(gameObject);
        }
    }
}
