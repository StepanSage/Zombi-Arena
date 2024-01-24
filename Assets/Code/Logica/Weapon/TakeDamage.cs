using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public static Action<int> DamageTextAction;

    [SerializeField] private int _damag;
    [SerializeField] private bool _isGun = false;

    [SerializeField] private GameObject _effect;
    [SerializeField] private Transform _spawnEffect;

    private Sheping _shepingCamera;

    private void Start()
    {
        _shepingCamera = FindObjectOfType<Sheping>();  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if (collision.GetComponent<Enemy>() != null)
            {
                collision.GetComponent<Enemy>().TakeDamage(_damag);
                collision.GetComponentInChildren<DamagText>().DamageBling();
                DamageTextAction?.Invoke(_damag);
                Instantiate(_effect, _spawnEffect.position, Quaternion.identity);
                _shepingCamera.ShakingCamera();

                if(_isGun == true)
                {
                    Destroy(gameObject);
                }
            }
        }
    }

    
}
