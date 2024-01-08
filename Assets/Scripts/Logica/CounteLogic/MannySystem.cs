using TMPro;
using UnityEngine;

public class MannySystem : MonoBehaviour
{
    [SerializeField] private TMP_Text _mannyText;

    public int _currentMony { get; private set; }

    private void Start()
    {
        _currentMony = PlayerPrefs.GetInt("Monny");
        _mannyText.text = _currentMony.ToString();
    }

    public void AddMonny(int monny)
    {
        _currentMony += monny;
        _mannyText.text = _currentMony.ToString();
        SaveGames.Monny(_currentMony);
    }

    public void WithdrawMoney(int money)
    {
        _currentMony -= money;
        _mannyText.text = _currentMony.ToString();
        SaveGames.Monny(_currentMony);
    }


}
