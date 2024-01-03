using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Weapon", menuName ="WeaponItem")]
public class WeapanInfo : ScriptableObject
{
    [SerializeField] private int _price;
    [SerializeField] private bool _isPurchased = false;

    public int Price => _price;
    public bool ISPurchased => _isPurchased;


    public void Buy() 
    {
        _isPurchased = true;
    }

}
