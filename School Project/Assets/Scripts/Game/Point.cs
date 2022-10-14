using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] private GameObject _parentObject;

    public GameObject ParentObject => _parentObject;
}
