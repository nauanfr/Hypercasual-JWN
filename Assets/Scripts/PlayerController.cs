using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PrimeTween;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private int timer;
    [SerializeField] private int _timer;
    [SerializeField] private Rigidbody _controller;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Transform _transform;
    public AnimationCurve curve;

    private void Awake()
    {
        PrimeTweenConfig.validateCustomCurves = false;
        StartCoroutine(Jump());
    }

    [ContextMenu("Testar Pulo")]
    private void Pular()
    {
        _controller.AddForce(new Vector3(0, _jumpForce, 0), ForceMode.Impulse);
    }   
    IEnumerator Jump()
    {
        bool jump = true;
        while (jump)
        {
            Pular2();
            yield return new WaitForSeconds(timer);

        }
    }

    [ContextMenu("Testar Pulo2 ")]
    private void Pular2()
    {
        Tween.PositionY(_transform, endValue: _jumpForce, duration: timer, curve);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }
}
