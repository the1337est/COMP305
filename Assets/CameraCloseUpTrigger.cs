using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCloseUpTrigger : MonoBehaviour
{

    public Camera CloseUpCamera;
    public Camera MainCamera;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            MainCamera.enabled = false;
            CloseUpCamera.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            MainCamera.enabled = true;
            CloseUpCamera.enabled = false;
        }
    }
}
