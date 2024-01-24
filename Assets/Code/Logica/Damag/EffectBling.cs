using TMPro;
using UnityEngine;

public class EffectBling : MonoBehaviour
{
    [SerializeField] private float _offsetPositionY;
    [SerializeField] private float _timeToDestroy;

    private float _startPositionY, _endPositionY, _currentPosition, _currentTime;
    [SerializeField] private TMP_Text _text;

    private void Awake() => _text = GetComponent<TMP_Text>();
    private void Start()
    {   
        _startPositionY = transform.localPosition.y;
        _endPositionY = _startPositionY + _offsetPositionY;   
    }

    private void OnEnable() => TakeDamage.DamageTextAction += Damage;

    private void OnDestroy() => TakeDamage.DamageTextAction -= Damage;
      

    private void Update()
    {
        LifeTime();
        Play();
        DeadTime();
    }

    private void LifeTime()
    {
        _currentTime += Time.deltaTime;
    }

    private void DeadTime()
    {
        if(_currentTime >  _timeToDestroy)
        {
            Destroy(gameObject);
        }
    }

    private void Play()
    {
        _currentPosition = Mathf.Lerp(_startPositionY, _endPositionY, _currentTime);
        transform.localPosition = new Vector3(transform.localPosition.x, _currentPosition, transform.localPosition.z);
    }

    private void Damage(int value)
    {
        _text.text = value.ToString();
    }

    


}
