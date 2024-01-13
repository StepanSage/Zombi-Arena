using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    [SerializeField] private float _timeLife;
    void Start()
    {
        StartCoroutine(DestroyObject(_timeLife));
    }

    private IEnumerator DestroyObject(float lifetime)
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
