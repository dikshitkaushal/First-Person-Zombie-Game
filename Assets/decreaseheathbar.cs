using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class decreaseheathbar : MonoBehaviour
{
    [SerializeField] Image image;
    private void Start()
    {
        image.fillAmount = 1f;
    }
    public void healthdecrease(float damage)
    {
        image.fillAmount -= damage / 100;
    }
    public void healthzero()
    {
        image.fillAmount = 0;
    }
}
