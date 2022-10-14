using UnityEngine;

public class SortLayerChanger : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sr;
    [SerializeField] private int _deltaOrder = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
            _sr.sortingOrder -= _deltaOrder;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
            _sr.sortingOrder += _deltaOrder;
    }
}
