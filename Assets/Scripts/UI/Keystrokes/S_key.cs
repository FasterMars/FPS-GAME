using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_key : MonoBehaviour
{
    public Image image;
    public Sprite sKeyDefault;
    public Sprite sKeyPressed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            image.sprite = sKeyPressed;
        }
        else
        {
            image.sprite = sKeyDefault;
        }
    }
}
