using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{
    public float moveSpeed;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, 360 * Time.deltaTime));
        rb.velocity = new Vector2(moveSpeed, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController temp = collision.gameObject.GetComponent<PlayerController>();
        if (temp == collision.gameObject.GetComponent<PlayerController>())
        {
            temp.Die();
        }
    }
}
