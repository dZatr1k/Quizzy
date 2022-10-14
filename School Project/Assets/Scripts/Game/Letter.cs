using System.Collections;
using UnityEngine;
using DG.Tweening;

public class Letter : MonoBehaviour
{
    public void Hide()
    {
        GetComponent<Animator>().SetTrigger("End");
        FindObjectOfType<PlayerMover>().IsMoveLocked = false;
        GetComponentsInChildren<SpriteRenderer>()[1].DOFade(0, 0.8f).SetEase(Ease.OutExpo);
        StartCoroutine(HideObject());
    }

    private IEnumerator HideObject()
    {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
    }
}
