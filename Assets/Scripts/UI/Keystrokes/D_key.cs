using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class D_key : MonoBehaviour
{
    public Image image;
    public Sprite dKeyDefault;
    public Sprite dKeyPressed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            image.sprite = dKeyPressed;
        }
        else
        {
            image.sprite = dKeyDefault;
        }
    }
}
