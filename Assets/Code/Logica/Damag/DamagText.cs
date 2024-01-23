using Unity.VisualScripting;
using UnityEngine;

public class DamagText : MonoBehaviour
{
    [SerializeField] private GameObject _prifabText;
    [SerializeField] private Transform _parentSpawn;

    private void Start() => TakeDamage.DamageText += DamageBling;
    private void OnDestroy() => TakeDamage.DamageText -= DamageBling;
      
    public void DamageBling()
    {
       Instantiate(_prifabText, _parentSpawn);
    }
}
