using System.Collections;
using UnityEngine;

public class WeaponAttack : MonoBehaviour
{
    [SerializeField] private Animator _attacAmination;
    [SerializeField] private string _nameAnimation;
    [SerializeField] private Collider2D _colliders = null;

    private void Update()
    {
        InputAttack();
    }
    private void InputAttack()
    {
        if(PauseGame._isPause == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Attack();
            }
        }
         
    }

    protected virtual void Attack()
    {   
            OnCollider();
            AnimationPlay(); 
    }   

    protected void AnimationPlay()
    {
        _attacAmination.Play(_nameAnimation);
    }

    protected void OnCollider()
    {
        float times = 1f;
        StartCoroutine(Delay(times));
       
    }

    IEnumerator Delay(float time)
    {
        _colliders.enabled = true;
        yield return new WaitForSeconds(time+5f);
        _colliders.enabled = false;
    }

}
