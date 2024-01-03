using UnityEngine;

public static class SaveGames 
{
    public static void Save()
    {

    }

    public static void IDWeaponSave(int CurrentWeaponID = 0) 
    {
        PlayerPrefs.SetInt("IDWeapon", CurrentWeaponID);
    }
}
