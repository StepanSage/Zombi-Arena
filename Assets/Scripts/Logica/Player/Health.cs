using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private Slider _slider;
    [SerializeField] private GameObject _loseGames;

    public void TakeDamage(int damage)
    {
        _health -= damage;  
        _slider.value = _health;

        if(_health == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //Destroy(gameObject);
        _loseGames.SetActive(true);
        Time.timeScale = 0;
    }
}
