using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int Health { get; private set; }
    public int Damag { get; private set; }

    [SerializeField] private SpriteRenderer _enemy;

    private void Start()
    {
        Health = 5;
        _enemy = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        _enemy.color = new Vector4(1f, 0.165f, 0.165f, 1f);
        StartCoroutine(Delay(0.2f));
        if(Health <= 0)
        {
            Destroy(gameObject);
        }  
    }

    private IEnumerator Delay(float time)
    {
        yield return new WaitForSeconds(time);
        _enemy.color = new Vector4(1f, 1f, 1f, 1f);

    }
}
