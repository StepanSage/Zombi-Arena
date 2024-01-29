using UnityEngine;

public class Buy : MonoBehaviour
{
    [SerializeField] private int _price;

    private Health _health;
    private MannySystem _monny;
    private Ammo _ammo;
    
    private void Start()
    {
        _monny = FindObjectOfType<MannySystem>(); 
        _ammo = FindObjectOfType<Ammo>();
        _health= FindObjectOfType<Health>();
    }

    public void BuyHealth(int addHealth)
    {
       if(_monny._currentMony - _price >= 0)
       {
            _monny.WithdrawMoney(_price);
            _health.AddHealt(addHealth);
       }
    }

    public void BuyAmmo(int CountAmmo) 
    {
        if(_monny._currentMony - _price >= 0)
        {
            _monny.WithdrawMoney(_price);
            _ammo.AddAmmo(CountAmmo);
        }
    }


}
