using System.Collections;
using UnityEngine;

public interface IInteractable
{
    void Interact();
}

public class Player : MonoBehaviour
{
    private GameObject _interactableObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<IInteractable>() != null)
            _interactableObject = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_interactableObject == collision.gameObject)
            _interactableObject = null;
    }

    public void TryInteract()
    {
        if (_interactableObject == null)
            return;

        GetComponent<PlayerMover>().TryMoveInDirection(Vector2.zero);
        GetComponent<PlayerMover>().IsMoveLocked = true;
        _interactableObject.GetComponent<IInteractable>().Interact();
    }
}
