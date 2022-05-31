using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class W_key : MonoBehaviour
{
    public Sprite wKeyDefault;
    public Sprite wKeyPressed;
    public Image image;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            image.sprite = wKeyPressed;
        }
        else
        {
            image.sprite = wKeyDefault;
        }
    }
}
