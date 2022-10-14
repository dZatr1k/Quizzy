using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RoomHider : MonoBehaviour
{
    [SerializeField] private bool _isFadedAtStart;

    List<SpriteRenderer> _sr = new List<SpriteRenderer>();

    private void Start()
    {
        var sr = GetComponentsInChildren<SpriteRenderer>();
        foreach (var item in sr)
            _sr.Add(item);

        if (TryGetComponent<SpriteRenderer>(out SpriteRenderer spriteRenderer))
            _sr.Add(spriteRenderer);

        if (!_isFadedAtStart)
        {
            foreach (var item in _sr)
            {
                item.color = new Color(item.color.r, item.color.g, item.color.b, 0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
            ShowRoom();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
            HideRoom();
    }

    private void HideRoom()
    {
        foreach (var item in _sr)
        {
            item.DOFade(0, 0.5f).SetEase(Ease.OutExpo);
        }
    }

    private void ShowRoom()
    {
        foreach (var item in _sr)
        {
            item.DOFade(255, 0.5f).SetEase(Ease.InExpo);
        }
    }
}
