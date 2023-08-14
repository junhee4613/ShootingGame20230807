using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{
    private float moveSpeed;
    public float rotateSpeed = 360;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(-1, -5);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed, 0);
        /*transform.eulerAngles = new Vector3(0, 0, rotateSpeed * Time.deltaTime);*/ //�̰� ȸ�� ���� ��Ÿ Ÿ�� ���� ��ġ��ŭ�� ����ȴ� Ex) 6.3 > 5.4 > 4.6......
        transform.rotation = Quaternion.Euler(0f, 0f, transform.rotation.eulerAngles.z + (rotateSpeed * Time.deltaTime)); //�̰�
    }
}
