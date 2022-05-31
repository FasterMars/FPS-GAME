using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlide : MonoBehaviour
{
    public GameObject door;

    [Header("Variables")]
    public float maximumOpening;
    public float maximumClosing;
    public float slideSpeed;

    bool playerIsHere;


    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere)
        {
            if (door.transform.position.x > maximumOpening)
            {
                door.transform.Translate(-1f * Time.deltaTime * slideSpeed, 0f, 0f);
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            playerIsHere = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            playerIsHere = false;
        }
    }
}
