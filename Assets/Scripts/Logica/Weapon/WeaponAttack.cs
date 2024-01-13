using System.Collections;
using UnityEngine;

public class WeaponAttack : MonoBehaviour
{
    [SerializeField] private Animator _attacAmination;
    [SerializeField] private string _nameAnimation;
    [SerializeField] private int _damag;
    [SerializeField] private Collider2D _colliders;

    [Header("effect Blood")]
    [SerializeField]
    private GameObject _effect;
    [SerializeField] private Transform _spawnEffect;

    [Header("Camera")]
    [SerializeField] private Animator _cameraAnimator;

    private const string _cameraNameAnim= "Camera";
   
               
    void Update()
    {
        Attack();
    }

    public void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnCollider();
            _attacAmination.Play(_nameAnimation);        
            ShakingCamera();

        }
        else
        {
           
        }
    }

    private void ShakingCamera()
    {
        _cameraAnimator.Play(_cameraNameAnim);
    }

    private void OnCollider()
    {
        float times = 1f;
        StartCoroutine(Delay(times));
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {      
            if(collision.GetComponent<Enemy>() != null)
            {
                collision.GetComponent<Enemy>().TakeDamage(_damag);
                Instantiate(_effect, _spawnEffect.position, Quaternion.identity);
               
            }
        }
    }


    IEnumerator Delay(float time)
    {
        _colliders.enabled = true;
        yield return new WaitForSeconds(time+5f);
        _colliders.enabled = false;
    }

}
