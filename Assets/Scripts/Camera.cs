using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private Transform _transform;
    private Vector3 _offset;

	private void Start()
    {
        _transform = transform;
        _offset = _transform.position - _player.position;

    }

    private void Update()
    {
        if(_player != null)
        {
            FollowThePlayer(_player);
        }
    }

    private void FollowThePlayer(Transform player)
	{
		_transform.position = new Vector3(player.position.x + _offset.x, player.position.y + _offset.y, transform.position.z);

        /*
        var target = new Vector3(player.position.x + _offset.x, player.position.y + _offset.y, transform.position.z);
        Vector3 currentPosition = transform.position;
        transform.position = currentPosition;
        */
    }
}