using System.Collections;
using UnityEngine;

public class WeaponAttack : MonoBehaviour
{
    [SerializeField] private Animator _attacAmination;
    [SerializeField] private string _nameAnimation;
    [SerializeField] private int _damag;
    [SerializeField] private Collider2D _colliders;
               
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
            Debug.Log("1");
        }
        else
        {
           
        }
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
