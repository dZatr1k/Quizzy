using System.Collections;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private SpriteRenderer _renderer;
    private Rigidbody2D _body;
    private Animator _animator;
    private string _currentState = "Idle1";
    private bool _isWalking = true;

    private const string _idle1 = "Idle1";
    private const string _idle2 = "Idle2";
    private const string _idle3 = "Idle3";
    private const string _walk = "Walk";

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _body = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_body.velocity != Vector2.zero)
            Walk();
        else
        {
            if (_isWalking == true)
                Idle1();
        }

        if (Mathf.Round(_body.velocity.x) > 0)
            _renderer.flipX = false;
        if (Mathf.Round(_body.velocity.x) < 0)
            _renderer.flipX = true;
    }

    private void ChangeAnimationState(string newState)
    {
        if (newState == _currentState)
            return;

        _currentState = newState;
        _animator.Play(newState);
    }

    private void Idle1()
    {
        _isWalking = false;
        ChangeAnimationState(_idle1);
        StopAllCoroutines();
        StartCoroutine(Idle2());
    }

    private IEnumerator Idle2()
    {
        yield return new WaitForSeconds(8);
        ChangeAnimationState(_idle2);
        StartCoroutine(Idle3());
    }

    private IEnumerator Idle3()
    {
        yield return new WaitForSeconds(8);
        ChangeAnimationState(_idle3);
    }

    private void Walk()
    {
        ChangeAnimationState(_walk);
        _isWalking = true;
    }
}
