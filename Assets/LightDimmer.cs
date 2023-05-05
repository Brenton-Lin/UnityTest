using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDimmer : MonoBehaviour
{
    public GameObject interactable;
    public float dimmerOutput;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        dimmerOutput = interactable.transform.localRotation.x;
        float lightDim = dimmerOutput;
        foreach(Transform child in transform)
        {
            child.Find("Point Light").GetComponent<LightFlicker>().startingIntensity = 2 + dimmerOutput;
           
        }
        
    }
}
