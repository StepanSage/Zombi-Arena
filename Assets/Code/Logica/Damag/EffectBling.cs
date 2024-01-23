using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBling : MonoBehaviour
{
    [SerializeField] private float _offsetPositionY;
    [SerializeField] private float _durationTime;

    private float _startPositionY, _endPositionY, _currentPosition, _time;
    void Start()
    {
        _startPositionY = transform.localPosition.y;
        _endPositionY = _startPositionY + _offsetPositionY;  
    }

    private void Update()
    {
        LifeTime();
        Play();
        DeadTime();
    }

    private void LifeTime()
    {
        _time = Time.time / _durationTime;
    }

    private void DeadTime()
    {
        if(_time > 1f)
        {
            Destroy(gameObject);
        }
    }

    private void Play()
    {
        _currentPosition = Mathf.Lerp(_startPositionY, _endPositionY, _time);
        transform.localPosition = new Vector3(transform.localPosition.x, _currentPosition, transform.localPosition.z);
    }

    


}
