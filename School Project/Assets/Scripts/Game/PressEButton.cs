using UnityEngine;
using DG.Tweening;

public class PressEButton : MonoBehaviour
{
    private SpriteRenderer _sr;

    private void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
        _sr.color = new Color(_sr.color.r, _sr.color.g, _sr.color.b, 0);
    }

    public void HideButton()
    {
        _sr.DOFade(0, 0.5f).SetEase(Ease.OutExpo);
    }

    public void ShowButton()
    {
        _sr.DOFade(255, 0.5f).SetEase(Ease.InExpo);
    }
}
