using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowShop : MonoBehaviour
{
    public void NotPause()
    {
        PauseGame.SetPause(false);
        Time.timeScale = 1.0f;
    }
}
