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
}
