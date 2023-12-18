using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private Vector3 _cameraPosition;
    [SerializeField] private float _speed;

    private Camera _camera;

    private void Awake() => _camera = FindObjectOfType<Camera>();
    
        
    

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
        transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime * Input.GetAxisRaw("Horizontal");
    }

    private void FlipHero()
    {
        if (Input.mousePosition.x < _cameraPosition.x)
        {

            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.mousePosition.x > _cameraPosition.x)
        {

            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
