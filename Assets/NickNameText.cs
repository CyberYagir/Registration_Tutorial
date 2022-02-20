using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NickNameText : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
    }

    private void Update()
    {
        transform.LookAt(mainCamera.transform);
    }
}
