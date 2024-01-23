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

    public static void Monny(int Count)
    {
        PlayerPrefs.SetInt("Monny", Count);
    } 

    public static void Records(int Count = 0)
    {
        PlayerPrefs.SetInt("Records", Count);
    }
}
