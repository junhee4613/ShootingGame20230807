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
    {   //OnBecameInvisible ī�޶� �������� �ʰ� �� �� ����Ǵ� �Լ�
        //OnBecamevisible�� ������ �� �ѹ� ����Ǵ� �Լ�
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
