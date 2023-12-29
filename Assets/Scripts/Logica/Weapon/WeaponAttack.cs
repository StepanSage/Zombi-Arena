using Scripts.Logica.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttack : MonoBehaviour
{
    [SerializeField] private Animator _attacAmination;
    [SerializeField] private string _nameAnimation;

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    public void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _attacAmination.Play(_nameAnimation);
            //_attacAmination.Play("New State");
            Debug.Log("1");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            //Enemy enemy = collision.GetComponent<Enemy>();

            if(gameObject.GetComponent<Enemy>() != null)
            {
                //enemy.TakeDamage(5);
                Debug.Log("hit");
            }
        }
    }
}
