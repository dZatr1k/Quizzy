using UnityEngine;

public class MenuInput : MonoBehaviour
{
    [SerializeField] private GameObject _difficultMenu;

    private MenuActions _input;

    private void Awake()
    {
        _input = new MenuActions();

        _input.Exit.Exit.performed += ctx => Exit();
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void Exit()
    {
        _difficultMenu.GetComponent<DifficultMenu>().Close();
    }
}
