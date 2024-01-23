using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScenes : MonoBehaviour
{
    public static LoadScenes Instance;

    public int _IDSence = 1;

    [SerializeField] private Slider _loadBar;
    private AsyncOperation _asyncOperation;
    private float _dalay = 0.9f;


    private void Start()
    {
        Instance = this;
        Load();
        DontDestroyOnLoad(this);
    }

    public void Load()
    {
        StartCoroutine(LoadSenceCor());
    }

    IEnumerator LoadSenceCor()
    {
        yield return new WaitForSeconds(1f);
        _asyncOperation = SceneManager.LoadSceneAsync(_IDSence);

        while (!_asyncOperation.isDone)
        {
            float progress = _asyncOperation.progress / _dalay;
            _loadBar.value = progress;    
            yield return 0;
        }
        gameObject.SetActive(false);
    }
}
