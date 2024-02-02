using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGun : WeaponAttack
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _pointSpawn;
    [SerializeField] private int Damage;

    [Header("Timer")]
    [SerializeField] private float _timeShot;

    private float _maxTimeShot;
    private Ammo _ammo;

    private void Start()
    {
        
        _maxTimeShot = _timeShot;
        _ammo = FindObjectOfType<Ammo>();
    }

    protected override void Attack()
    {
        if (_ammo.AmmoCount > 0)
        {
            SpawnBullion();
            AnimationPlay();
            _ammo.ChangeAmmo(1);
        }
       
    }

    private void SpawnBullion()
    {
        var bullion = Instantiate(_prefab, _pointSpawn.position, Quaternion.identity);
        bullion.GetComponent<TakeDamage>()._damag = Damage;
    }


}
