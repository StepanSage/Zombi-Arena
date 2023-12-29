using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManagar : MonoBehaviour
{
    [Header("Sound"),Space(5)]
    [SerializeField] private Sprite _onSound;
    [SerializeField] private Sprite _offSound;
    [SerializeField] private Image imageSound;

    private bool _switchSound = true;

   public void SoundSetting()
   {
        if(_switchSound = !_switchSound) 
        {
            imageSound.sprite = _onSound;
        }
        else
        {
            imageSound.sprite = _offSound;
        }
   }
}
