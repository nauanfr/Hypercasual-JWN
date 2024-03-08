using PrimeTween;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlatformMovement : MonoBehaviour
{
    public float speed;
    public MeshRenderer teste;

    public int type;

    private void Update()
    {
        transform.Translate(Vector3.right* speed * Time.deltaTime);
    }

}
