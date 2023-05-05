using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{


    public float flickerIntensity;
    public float flickersPerSecond;
    public float speedRandomness;
    public float flickerWaver = 1f;
    public float startingIntensity;

    private float time;
    private Light light;

    
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        startingIntensity = light.intensity;
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * (1 - Random.Range(-speedRandomness, speedRandomness)) * Mathf.PI;
        light.intensity = startingIntensity + Mathf.Sin(time * flickersPerSecond) * flickerIntensity;
        transform.position = transform.position + new Vector3(Mathf.Sin(time * flickersPerSecond)*flickerWaver, 0, Mathf.Sin(time * flickersPerSecond)*flickerWaver);
    }
}
