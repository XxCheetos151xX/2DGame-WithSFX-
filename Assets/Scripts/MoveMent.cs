using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerrigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private float _playerspeed;
    [SerializeField] private float _jumpheight;
    [SerializeField] private Animator _playeranimator;
    [SerializeField] private AudioSource _JumpEffect;
    private bool _isgrounded;





    void FixedUpdate()
    {
        _playerrigidbody.velocity = new Vector2(_joystick.Horizontal * _playerspeed, _playerrigidbody.velocity.y);
        _playeranimator.SetFloat("speed", Mathf.Abs(_playerrigidbody.velocity.x));
        _playeranimator.SetFloat("down", _joystick.Vertical);
        if (_playerrigidbody.velocity.x < 0)
        {
            gameObject.transform.localScale =new Vector3(-1, 1, 1);

        }
        if (_playerrigidbody.velocity.x > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private void OnCollisionEnter2D()
    {
        _playeranimator.SetFloat("height", 0f);
        _isgrounded = true;
    }

    private void OnCollisionExit2D()
    {
        _isgrounded = false;
    }

    public void Jump()
    {
        if(_isgrounded = true)
        {
            _playerrigidbody.velocity = new Vector2(_playerrigidbody.velocity.x, _jumpheight);
            _playeranimator.SetFloat("height", _playerrigidbody.velocity.y);
            _JumpEffect.Play();
        }
    }
    public void HandleKeyBoardInput()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _playerrigidbody.velocity = new Vector2(_playerspeed, _playerrigidbody.velocity.y);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _playerrigidbody.velocity = new Vector2(-_playerspeed, _playerrigidbody.velocity.y);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        { }
            Jump();
        }
    }



