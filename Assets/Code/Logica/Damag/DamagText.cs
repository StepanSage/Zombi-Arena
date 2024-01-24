using Unity.VisualScripting;
using UnityEngine;

public class DamagText : MonoBehaviour
{
    [SerializeField] private GameObject _prifabText;
    [SerializeField] private Transform _parentSpawn;

    //private void Start() => Enemy.DamageText += DamageBling;
    //private void OnDestroy() => Enemy.DamageText -= DamageBling;
      
    public void DamageBling()
    {
       Instantiate(_prifabText, _parentSpawn);
    }
}
