using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionWiggle : MonoBehaviour
{
    public Quaternion startRotation;
    public Quaternion endRotation;
    public float speed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Animate()
    {
        StartCoroutine(Wiggle());
    }

    IEnumerator Wiggle()
    {
        float timePassed = 0;
        while (timePassed < 3)
        {
            float t = (Mathf.Sin(Time.time * speed) + 1.0f) / 2.0f;
            transform.rotation = Quaternion.Slerp(startRotation, endRotation, t);
            timePassed += Time.deltaTime;

            yield return null;
        }
        
    }
}
