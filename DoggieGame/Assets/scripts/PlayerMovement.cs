using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

private float horizontalMovement;

public float speed = 8f;

public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(horizontalMovement = Input.GetAxisRaw("Horizontal"));


    }

    //private void FixedUpdate(){

    //rb.velocity = new.Vector2(Horizontal * speed, rb.velocity.y);
    //}
}
