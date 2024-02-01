using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health; 
    [SerializeField] private Slider _slider;
    [SerializeField] private GameObject _loseGames;

    private int _maxHealth;

    private void Start()
    {
        _maxHealth = _health;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;  
        _slider.value = _health;

        if(_health == 0)
        {
            Die();
        }
    }

    public void AddHealt(int Count)
    {
        if(_health + Count <= _maxHealth)
        {
            _health += Count;
            _slider.value = _health;
        }
        else
        {
            _health = _maxHealth;
            _slider.value = _maxHealth;
        }
    }

    private void Die()
    {
        //Destroy(gameObject);
        _loseGames.SetActive(true);
        Time.timeScale = 0;
    }
}
