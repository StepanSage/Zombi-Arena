using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUse : MonoBehaviour
{
    [SerializeField] private GameObject[] Allweapon;
    private void Awake()
    {
        int Id = PlayerPrefs.GetInt("IDWeapon");
        Allweapon[Id].SetActive(true);
    }
}
