using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LightFlicker : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;
    public Light FlickerLight1;
    public Light FlickerLight2;
    // public Light FlickerLight3;
    // public Light FlickerLight4;

    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickerLights());
        }
    }

    IEnumerator FlickerLights()
    {
        isFlickering = true;

        FlickerLight1.enabled = false;
        FlickerLight2.enabled = false;
        // FlickerLight3.enabled = false;
        // FlickerLight4.enabled = false;
        
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        
        FlickerLight1.enabled = true;
        FlickerLight2.enabled = true;
        // FlickerLight3.enabled = true;
        // FlickerLight4.enabled = true;
        
        timeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }
}
