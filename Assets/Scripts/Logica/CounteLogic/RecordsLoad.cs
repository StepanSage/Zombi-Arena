using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RecordsLoad : MonoBehaviour
{
    [SerializeField] private TMP_Text _recordsText;
    void Start()
    {
        _recordsText.text = PlayerPrefs.GetInt("Records").ToString();
    }

   
}
