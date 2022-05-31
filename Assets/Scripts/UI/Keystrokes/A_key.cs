using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class A_key : MonoBehaviour
{
    public Image image;
    public Sprite aKeyDefault;
    public Sprite aKeyPressed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            image.sprite = aKeyPressed;
        }
        else
        {
            image.sprite = aKeyDefault;
        }
    }
}
