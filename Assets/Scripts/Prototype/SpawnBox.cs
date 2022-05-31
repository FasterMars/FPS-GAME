using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public GameObject box;
    public Transform boxInstantiatePos;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Instantiate(box, boxInstantiatePos.transform);
        }
    }
}
