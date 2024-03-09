using PrimeTween;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed;
    public MeshRenderer teste;
    public Material _material;
    public int _type;

    private void Update()
    {
        transform.Translate(Vector3.right* speed * Time.deltaTime);
    }

    public void UpdateColorAndType(int type)
    {
        _material = teste.materials[0];
        switch (type)
        {
            case 0:
                _material.color = Color.red;
                _type = 0;
                break;
            case 1:
                _material.color = Color.green;
                _type = 1;
                break;
            case 2:
                _material.color = Color.blue;
                _type = 2;
                break;

        }
    }

}
