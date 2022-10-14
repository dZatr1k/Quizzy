using UnityEngine;

public class CardAnimation : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlaySlide1() => _animator.SetTrigger("Slide1");

    public void PlaySlide2() => _animator.SetTrigger("Slide2");
}
