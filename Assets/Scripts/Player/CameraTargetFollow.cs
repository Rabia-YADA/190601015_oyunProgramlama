using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTargetFollow : MonoBehaviour
{
    public Transform targetPlayerTransform;
    public Vector3 cameraOffset = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - targetPlayerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lastPosition = targetPlayerTransform.position + cameraOffset;

        transform.position = lastPosition;
    }
}
