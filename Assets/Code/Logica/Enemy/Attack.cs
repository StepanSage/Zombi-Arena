using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private int _damag;
    private Health _health;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            if(collision.GetComponent<PlayerController>() != null)
            {
                _health = collision.GetComponent<Health>();
                _health.TakeDamage(_damag);
            }
        }
    }
}
