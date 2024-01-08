using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Profiling;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    private int _currentScore;

    private int _highttecord;

    private void Start()
    {
        _highttecord = PlayerPrefs.GetInt("Records");
    }

    public void AddScore(int monny)
    {
        _currentScore += monny;
        _scoreText.text = _currentScore.ToString();
        if(_currentScore > _highttecord)
        {
            SaveGames.Records(_currentScore);
        }
       
    }

   
}
