using UnityEngine;

public class Buy : MonoBehaviour
{
    [SerializeField] private MannySystem _monny;
    [SerializeField] private int _price;
    [SerializeField] private Health _health;
    
    public void BuyHealth(int addHealth)
    {
       if(_monny._currentMony - _price >= 0)
       {
            _monny.WithdrawMoney(_price);
            _health.AddHealt(addHealth);
       }
       

    }
}
