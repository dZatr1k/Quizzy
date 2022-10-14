using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _acceleartionTime;

    private AudioSource _source;
    private Rigidbody2D _body;
    private Vector2 _oldVelocity = Vector2.zero;
    private Vector2 _currentVelocity = Vector2.zero;
    private bool _isMoveLocked = true;
    private float _currentTime = 0;

    public bool IsMoveLocked 
    {
        get => _isMoveLocked;
        set
        {
            _isMoveLocked = value;
        }
    }

    private void Start()
    {
        _body = GetComponent<Rigidbody2D>();
        _source = GetComponent<AudioSource>();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _body.velocity = _currentVelocity;    }

    private void FixedUpdate()
    {
        _body.velocity = Vector2.Lerp(_oldVelocity, _currentVelocity, _currentTime / _acceleartionTime);
        _currentTime += Time.fixedDeltaTime;

        if (_body.velocity != Vector2.zero)
        {
            _source.loop = true;
            if (!_source.isPlaying)
            {
                _source.Play();
            }
        }
        else
        {
            _source.loop = false;
            _source.Pause();
        }

    }

    public void TryMoveInDirection(Vector2 direction)
    {
        if (!_isMoveLocked)
        {
            _currentTime = 0;
            _oldVelocity = _body.velocity;
            _currentVelocity = direction * _speed;
        }
    }
}
