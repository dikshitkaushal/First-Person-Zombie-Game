using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    ammoslot ammoSlot;
    [SerializeField] ammoslot[] ammoslots;
    [System.Serializable]
    private class ammoslot
    {
        public ammotype ammotype;
        public int ammoamount;
    }
    public int currentammo(ammotype ammotype)
    {
        return getammoslot(ammotype).ammoamount;
    }
    public int decreaseammo(ammotype ammotype)
    {
        return getammoslot(ammotype).ammoamount--;
    }
    public void increaseammo(ammotype ammotype,int amoamount)
    {
        getammoslot(ammotype).ammoamount += amoamount;
    }
    private ammoslot getammoslot(ammotype ammotype)
    {
        foreach(ammoslot slot in ammoslots)
        {
            if(slot.ammotype==ammotype)
            {
                return slot;
            }
        }
        return null;
    }
}
