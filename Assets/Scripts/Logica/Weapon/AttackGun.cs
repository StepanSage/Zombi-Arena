using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGun : WeaponAttack
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _pointSpawn;

    [Header("Timer")]
    [SerializeField] private float _timeShot;

    private float _maxTimeShot;

    private void Start() => _maxTimeShot = _timeShot;

    protected override void Attack()
    {
        //Timer();
        SpawnBullion();
        AnimationPlay();
    }

    private void SpawnBullion()
    {
        var bullion = Instantiate(_prefab, _pointSpawn.position, Quaternion.identity);
    }

    private void Timer()
    {
        if(_timeShot <= 0)
        {
           
            _timeShot = _maxTimeShot;
        }
        else
        {
            _timeShot -= Time.deltaTime;
        }
    }

}
