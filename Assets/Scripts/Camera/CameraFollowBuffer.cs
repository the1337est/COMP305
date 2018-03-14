using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBuffer : MonoBehaviour
{

    public Transform Target;
    public Transform MoveThreshold;

    private void Update()
    {
        if (Target.position.x > MoveThreshold.position.x)
        {
            transform.position = new Vector3(Target.position.x, transform.position.y, transform.position.z);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(MoveThreshold.position, MoveThreshold.position + Vector3.up * 20f);
        Gizmos.DrawLine(MoveThreshold.position, MoveThreshold.position + Vector3.down * 20f);
    }
}
