using UnityEngine;

public class Item : MonoBehaviour, IInteractable
{
    [SerializeField] private string _text;

    private bool _isCollectable = false;
    public void Interact()
    {
        if(_isCollectable)
        {
            FindObjectOfType<PlayerMover>().IsMoveLocked = true;
            StartCoroutine(FindObjectOfType<GameLoop>().StartLoop());
        }
    }
}
