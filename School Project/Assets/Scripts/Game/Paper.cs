using System.Collections;
using UnityEngine;

public class Paper : MonoBehaviour, IInteractable
{
    [SerializeField] private Sprite[] _sprites;

    private bool _isInteractable;

    private void OnEnable()
    {
        GetComponent<SpriteRenderer>().sprite = _sprites[Random.Range(0, _sprites.Length - 1)];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.GetComponentInChildren<PressEButton>().ShowButton();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.GetComponentInChildren<PressEButton>().HideButton();
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }

    public void Interact()
    {
        if(_isInteractable == false)
        {
            _isInteractable = true;
            FindObjectOfType<PlayerMover>().IsMoveLocked = true;
            StartCoroutine(FindObjectOfType<GameLoop>().StartLoop());
            StartCoroutine(Wait());
        }
    }

}
