using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float moveSpeed;
    private void Start()
    {
        
    }
    private void Update()
    {
        transform.position = new Vector3(transform.position.x + (moveSpeed * Time.deltaTime), transform.position.y, transform.position.z);
    }

    private void OnBecameInvisible()
    {   //OnBecameInvisible 카메라에 비춰지지 않게 될 때 실행되는 함수
        //OnBecamevisible에 비춰질 때 한번 실행되는 함수
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        /*HurtPlayer hurtPlayer = collision.GetComponent<HurtPlayer>();
        if(hurtPlayer != null)
        {
            Destroy(collision.gameObject);
        }*/
    }
}
