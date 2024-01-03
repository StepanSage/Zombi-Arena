using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public float climbSpeed = 3f; // Скорость подъема по лестнице

    private bool isClimbing = false;
    private float inputVertical;
    private Rigidbody2D rb;


    private void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        inputVertical = Input.GetAxis("Vertical");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // Если персонаж столкнулся с лестницей
        if (collision.CompareTag("Ladder"))
        {
            rb.gravityScale = 0;
            Clamps(); 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            rb.gravityScale = 1;
        }
    }

    private void Clamps()
    {
        rb.velocity = new Vector2(rb.velocity.x, inputVertical * climbSpeed*Time.deltaTime);
    }




}
