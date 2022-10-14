using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMover))]
[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{
    private Letter _letter;
    private PauseMenu _pauseMenu;
    private PlayerInputSystem _input;
    private Player _player;
    private PlayerMover _mover;
    private bool _isPauseMenuLocked = false;

    public bool IsPauseMenuLocked
    {
        set
        {
            _isPauseMenuLocked = value;
        }
    }

    private void Awake()
    {
        _letter = FindObjectOfType<Letter>();
        _pauseMenu = FindObjectOfType<PauseMenu>();
        _player = GetComponent<Player>();
        _mover = GetComponent<PlayerMover>();

        _input = new PlayerInputSystem();

        _input.Moving.Move.performed += ctx => Move();
        _input.Interactions.Interact.performed += ctx => Interact();
        _input.Interactions.PauseMenu.performed += ctx => OpenPauseMenu();
        _input.Interactions.Continue.performed += ctx => HideLetter();

        _isPauseMenuLocked = false;
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void Move()
    {
        _mover.TryMoveInDirection(_input.Moving.Move.ReadValue<Vector2>());
    }

    private void Interact()
    {
        _player.TryInteract();
    }

    private void OpenPauseMenu()
    {
        if (_isPauseMenuLocked == false)
            _pauseMenu.SetActive();
    }

    private void HideLetter()
    {
        _letter.Hide();
    }
}
