using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Animator _animator;
    private Transform _transform;
    [SerializeField] private float _moveSpeed = 2f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        _transform = transform;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Debug.Log(_transform.position);
        var _target = _transform.position + new Vector3(1f, 0f, 0f);
        _transform.position = Vector3.Lerp(_transform.position, _target, Time.deltaTime * _moveSpeed);
        Debug.Log(_transform.position);
    }

    private void StartMoveAnimation()
    {

    }
}
