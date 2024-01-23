using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int Health { get; private set; }
    public int Damag { get; private set; }

    [SerializeField] private SpriteRenderer _enemy;
    [SerializeField] private int _hp;

    [Header("Monny"),Space(10)]
    [SerializeField] private MannySystem mannySystem;
    [SerializeField] private int _minMonnyDrop = 1;
    [SerializeField] private int _maxMonnyDrop = 10;

    private Score _score;
    private int countKill = 1;

    private void Start()
    {
        Health = _hp;
        _enemy = GetComponent<SpriteRenderer>();
        mannySystem = FindFirstObjectByType<MannySystem>();
        _score = FindObjectOfType<Score>();
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        _enemy.color = new Vector4(1f, 0.165f, 0.165f, 1f);
        StartCoroutine(Delay(0.2f));
        if(Health <= 0)
        {
            mannySystem.AddMonny(Random.Range(_minMonnyDrop, _maxMonnyDrop));
            _score.AddScore(countKill);
            Destroy(gameObject);
        }  
    }

    private IEnumerator Delay(float time)
    {
        yield return new WaitForSeconds(time);
        _enemy.color = new Vector4(1f, 1f, 1f, 1f);

    }
}
