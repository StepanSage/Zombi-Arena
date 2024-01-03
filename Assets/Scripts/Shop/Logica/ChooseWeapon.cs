using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseWeapon : MonoBehaviour
{
    public void Choose(int Idweapon)
    {
        SaveGames.IDWeaponSave(Idweapon);
    }
}
