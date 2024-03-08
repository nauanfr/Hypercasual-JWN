using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrimeTween;
using System.Runtime.CompilerServices;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private int timer;
    public int currentType;
    [SerializeField] private Rigidbody _controller;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Transform _transform;
    public AnimationCurve curve;

    private void Awake()
    {
        PrimeTweenConfig.validateCustomCurves = false;
        StartCoroutine(Jump());
    }
    
    IEnumerator Jump()
    {
        bool jump = true;
        while (jump)
        {
            Tween.PositionY(_transform, endValue: _jumpForce, duration: timer, curve);
            yield return new WaitForSeconds(timer);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Platform"))
        {
            if (other.GetComponent<PlatformMovement>().type.Equals(currentType))
            {
                Debug.Log("Acertou");
            }
            else
                Debug.Log("Errou");
        }
    }
}