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
    [SerializeField] MannySystem _monnySystem;

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
        _monnySystem = FindObjectOfType<MannySystem>();
    }

    public void BuyWeapon()
    {
        if(_monnySystem._currentMony >= _prace)
        {
            _monnySystem.WithdrawMoney(_prace);
            _weapanInfo.Buy();
            _adsButton.SetActive(false);
            _buyWeaponBotton.SetActive(false);
            _select.SetActive(true);
        }
        else
        {
            Debug.Log("Не достаточно стредств");
        }
        
    }
}
