using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector3 _cameraPosition;
    [SerializeField] private float _speed;

    private Camera _camera;
    private float _horizontal;
    private SpriteRenderer _spriteCharacter;

    private void Awake() => _camera = FindObjectOfType<Camera>();

    private void Start()
    {
        _spriteCharacter = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        CameraPosition();
        MoveHero(_speed);
        FlipHero();
    }

    public void CameraPosition()
    {
        _cameraPosition = _camera.WorldToScreenPoint(transform.position);
    }

    public void MoveHero(float Speed)
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime * _horizontal;
    }

    private void FlipHero()
    {
        if (_horizontal < 0)
        {
            _spriteCharacter.flipX = true;
            //transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (_horizontal > 0)
        {
            _spriteCharacter.flipX = false;
            //transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
