using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHelp : MonoBehaviour
{
    [SerializeField] private GameObject _helpWindow;
    [SerializeField] private GameObject _windowsShop;

    private bool _isAction = false;

    private void Update()
    {
        if(_isAction == true)
        {
            if(Input.GetKeyDown(KeyCode.E)) 
            {
                _windowsShop.SetActive(true);
                Time.timeScale = 0;
                PauseGame.SetPause(true);
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StateWindow(true);
            _isAction = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StateWindow(false);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            _isAction = false;
        }
    }

    public void StateWindow(bool state)
    {
        _helpWindow.SetActive(state);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
