using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHelp : MonoBehaviour
{
    [SerializeField] private GameObject _helpWindow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StateWindow(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StateWindow(false);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void StateWindow(bool state)
    {
        _helpWindow.SetActive(state);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
