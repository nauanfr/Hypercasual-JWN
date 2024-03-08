using PrimeTween;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
public class PlatformMovement : MonoBehaviour
{
    public float speed;
   
    private void Update()
    {
        transform.Translate(Vector3.right* speed * Time.deltaTime);
    }

}
