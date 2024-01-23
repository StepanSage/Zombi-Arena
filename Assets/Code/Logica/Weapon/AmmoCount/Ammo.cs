using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] private TMP_Text _textAmmo;

    public int AmmoCount { get; private set; }

    private void Start()
    {
        AmmoCount = 50;
    }

    void Update()
    {
        if(AmmoCount < 0)
        {
            AmmoCount = 0;
        }

        _textAmmo.text = AmmoCount.ToString();
    }

    public void ChangeAmmo(int count)
    {
        AmmoCount -= count;
    }

    public void AddAmmo(int count)
    {
        AmmoCount += count;
    }
}
