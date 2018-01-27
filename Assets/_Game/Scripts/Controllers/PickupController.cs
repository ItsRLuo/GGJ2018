using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public int originalLayerMask;
    public LayerMask holdLayer;

    // Use this for initialization
    void Start()
    {
        originalLayerMask = this.gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        // stop bad hand physics by setting the layer
        this.gameObject.layer = GetLayerIntFromMask(holdLayer);
        Debug.Log(GetLayerIntFromMask(holdLayer));

    }

    private int GetLayerIntFromMask(LayerMask myLayer)
    {
        int layerNumber = 0;
        int layer = myLayer.value;
        while (layer > 0)
        {
            layer = layer >> 1;
            layerNumber++;
        }
        return layerNumber;
    }
}
