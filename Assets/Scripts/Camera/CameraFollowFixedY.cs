using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowFixedY : MonoBehaviour
{

    public float Size = 5;

    public Transform Target;

    private void Start()
    {
        GetComponent<Camera>().orthographicSize = Size;
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(Target.position.x, transform.position.y, transform.position.z);
    }

}
