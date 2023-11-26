using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 250;
    private float playerInput = 0;
    private Rigidbody2D rb;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Update(){
        playerInput = Input.GetAxisRaw("Horizontal");
        SwapSprite();
    }
    void SwapSprite(){
        if (playerInput > 0){
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
        }
        else if (playerInput < 0){
            transform.localScale = new Vector3(-1 * Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
        }
    }
    void FixedUpdate(){
        rb.velocity = new Vector2(playerInput * speed * Time.fixedDeltaTime, 0);
    }   
}