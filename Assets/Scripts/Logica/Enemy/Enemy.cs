using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health { get; private set; }
    public int Damag { get; private set; }

    private void Start()
    {
        Health = 5;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if(Health <= 0)
        {
            Destroy(gameObject);
        } 
    }
}
