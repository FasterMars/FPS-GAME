using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Space_key : MonoBehaviour
{
    public Sprite spaceKeyDefault;
    public Sprite spaceKeyPressed;
    public Image image;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            image.sprite = spaceKeyPressed;
        }
        else
        {
            image.sprite = spaceKeyDefault;
        }
    }
}
