using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform targetTf;
    [SerializeField] private Vector3 cameraOffsetVector;
    private Transform _cameraTf;

    private void Awake()
    {
        _cameraTf = Camera.main.transform;
    }

    private void LateUpdate()
    {
        var position = targetTf.position;
        _cameraTf.position = new Vector3(_cameraTf.position.x,position.y,position.z) + cameraOffsetVector;
    }
}