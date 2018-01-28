using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public bool isPickedUp = false;
    public bool isPossiblePickup;
    //public int originalLayerMask; // TODO
    
    void Start()
    {
        //originalLayerMask = this.gameObject.layer; // TODO
    }
    
    void Update()
    {
    }

    public void PickMeUp()
    {
        // stop bad hand physics by setting the layer
        isPickedUp = true;
        this.gameObject.layer = LayerMask.NameToLayer("ObjHandHold");
    }
    public void DropMe()
    {
        // stop bad hand physics by setting the layer
        isPickedUp = false;
        this.gameObject.layer = LayerMask.NameToLayer("Default");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("Hand") && this.gameObject.layer != LayerMask.NameToLayer("ObjHandHold"))
        {
            // TODO: change color or give a nice looking outline shader here maybe?
            isPossiblePickup = true;
        }
    }

}
