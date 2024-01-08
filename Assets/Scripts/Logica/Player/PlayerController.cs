using UnityEngine;


public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private float _speed;
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _allWeapon;
   
    [SerializeField] private float _horizontal;
    private SpriteRenderer _spriteCharacter;

   

    private void Start()
    {
        _spriteCharacter = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        MoveHero(_speed);
        FlipHero();
        AnimationPlay();
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
            _allWeapon.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (_horizontal > 0)
        {
            _spriteCharacter.flipX = false;
            _allWeapon.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void AnimationPlay()
    {
        if(_horizontal != 0)
        {
            _animator.SetBool("IsRun", true);
        }
        else if(_horizontal == 0)
        {
            _animator.SetBool("IsRun", false);
        }
    }
}
