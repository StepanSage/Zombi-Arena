using UnityEngine;

public class BullionMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private PlayerController characterController;
    private bool _isDirection;

    private void Start()
    {
        characterController = FindObjectOfType<PlayerController>();
        _isDirection = Direction();
    }

    void Update()
    {
        if (_isDirection == false)
        {
            transform.Translate(transform.right * _speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-transform.right * _speed * Time.deltaTime);
        }
          
    }

    
    public bool Direction()
    {
        if(characterController.GetComponent<SpriteRenderer>().flipX == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}
