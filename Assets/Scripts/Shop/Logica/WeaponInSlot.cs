using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponInSlot : MonoBehaviour
{
    [SerializeField] private WeapanInfo _weapanInfo;
    [SerializeField] private TMP_Text _priceText;
    [SerializeField] private GameObject _adsButton;
    [SerializeField] private GameObject _buyWeaponBotton;
    [SerializeField] private GameObject _select;

    private int _prace;


    private void Start()
    {
        if(_weapanInfo.ISPurchased == true)
        {
            _adsButton.SetActive(false);
            _buyWeaponBotton.SetActive(false);
            _select.SetActive(true);
        }
        else
        {
            _priceText.text = _weapanInfo.Price.ToString();
            _prace = _weapanInfo.Price;
        }       
    }

    public void BuyWeapon()
    {
        _weapanInfo.Buy();
        _adsButton.SetActive(false);
        _buyWeaponBotton.SetActive(false);
        _select.SetActive(true);
    }
}
