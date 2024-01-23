using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMainMeny : MonoBehaviour
{
    [SerializeField] private LoadScenes loadScenes;
    void Awake()
    {
        loadScenes = LoadScenes.Instance;
        
    }

    public void Exit()
    {
        Time.timeScale = 1;
        loadScenes._IDSence = 0;
        loadScenes.gameObject.SetActive(true);
        loadScenes.Load();
    }
  
}
