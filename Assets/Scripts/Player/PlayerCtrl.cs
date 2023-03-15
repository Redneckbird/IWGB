using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;  //이동속도
    public float jumpSpeed;  //점프속도
    int jumpstack = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 3f;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.X) && jumpstack < 1) {
            rb.AddForce(Vector2.up * jumpSpeed);
            jumpstack++;
        }
    }
}
