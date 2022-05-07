using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRotation : MonoBehaviour
{
    [SerializeField] Material skyMat;

    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        skyMat.SetFloat("_Rotation", Time.time * speed);
    }
}
